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
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            return 0;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            return 0;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete>paquetes)
        {

        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            foreach (var item in impuestosAduana)
            {
                if (item is IAduana && paquete is IAduana)
                {
                    impuestosAduana.Add(paquete);
                }
                else if(paquete is IAfip)
                {
                    impuestosAfip.Add((IAfip)paquete);
                }
            }
        }


    }
}
