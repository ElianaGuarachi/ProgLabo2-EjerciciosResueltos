using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        };

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            //metodo sleep
            Thread.Sleep(2000);
            return true;
        }


    }
}
