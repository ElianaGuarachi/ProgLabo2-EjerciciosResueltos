using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaquetePesado : Paquete, IAfip
    {
        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }

        decimal IAfip.Impuestos
        {
            get
            {
                return this.costoEnvio * 0.25M;
            }
        }

        public override decimal AplicarImpuestos()
        {
            return base.AplicarImpuestos() + ((IAfip)this).Impuestos;
        }

        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
            :base(codigoSeguimiento,costoEnvio,destino,origen,pesoKg)
        {

        }

    }
}
