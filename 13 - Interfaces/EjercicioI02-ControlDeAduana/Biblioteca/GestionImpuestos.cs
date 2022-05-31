using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestionImpuestos 
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuesto = 0;

            foreach (IAduana impuesto in impuestosAduana)
            {
                totalImpuesto += impuesto.Impuestos;
            }
            return totalImpuesto;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalImpuesto = 0;

            foreach (IAfip impuesto in impuestosAfip)
            {
                totalImpuesto += impuesto.Impuestos;
            }
            return totalImpuesto;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete>paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            if (paquete is not null)
            {
                impuestosAduana.Add(paquete);

                if (paquete is IAfip)
                {
                    impuestosAfip.Add((IAfip)paquete);
                }
            }
        }


    }
}
