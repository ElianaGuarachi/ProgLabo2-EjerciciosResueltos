using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    public class Local : Llamada
    {
        private float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        private float CalcularCosto()
        {
            return Duracion * costo;
        }

        public override bool Equals(object obj)
        {
            if (obj is not null && obj is Local)
            {
                return true;
            }
            return false;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo Llamada: {CostoLlamada}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }



    }
}
