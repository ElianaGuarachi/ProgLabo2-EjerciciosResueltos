using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get 
            { 
                return CalcularCosto(); 
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float precio = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    precio = Duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    precio = Duracion * 1.25F;
                    break;
                case Franja.Franja_3:
                    precio = Duracion * 0.66F;
                    break;
            }
            return precio;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");
            
            return sb.ToString();
        }









    }
}
