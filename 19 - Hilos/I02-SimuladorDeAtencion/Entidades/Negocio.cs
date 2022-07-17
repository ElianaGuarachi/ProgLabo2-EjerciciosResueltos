using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NameGenerator.Generators;

namespace Entidades
{
    public class Negocio
    {
        private static RealNameGenerator name;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            name = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();

            //abrir todas las cajas
            hilos.AddRange(AbrirCajas());

            hilos.Add(Task.Run(() =>
            {
                do
                {
                    clientes.Enqueue(name.Generate());
                    Thread.Sleep(1000);
                } while (true);
            }));

            hilos.Add(Task.Run(()=>
            {
                do
                {
                    //caja con menos clientes
                    Caja caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                    if(clientes.TryDequeue(out string cliente))
                    {
                        if (!string.IsNullOrWhiteSpace(cliente))
                        {
                            caja.AgregarCliente(cliente);
                        }
                    }
                } while (true);
            }));

            return hilos;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja item in cajas)
            {
                hilos.Add(item.IniciarAtencion());
            }

            return hilos;
        }
    }
}
