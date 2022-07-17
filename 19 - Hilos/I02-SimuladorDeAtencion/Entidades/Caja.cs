using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace Entidades
{
    
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string texto);

        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        public string NombreCaja { get => this.nombreCaja; }

        public int CantidadDeClientesALaEspera { get => this.clientesALaEspera.Count; }

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(()=>
            {
                do
                {
                    if (clientesALaEspera.Any())
                    {
                        string cliente = clientesALaEspera.Dequeue();
                        delegadoClienteAtendido.Invoke(this, cliente);
                        Thread.Sleep(random.Next(1000,5000));
                    }
                } while (true);
            });
        }
    }
}
