using System;
using System.Text;

namespace Central
{
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }

    public abstract class Llamada
    {
        
        private float duracion;
        private string nroDestino;
        private string nroOrigen;

        public abstract float CostoLlamada { get; }
        
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nro Origen: {NroOrigen}");
            sb.AppendLine($"Nro Destino: {NroDestino}");
            sb.AppendLine($"Duracion: {Duracion}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            return 0;
        }

        public static bool operator == (Llamada l1, Llamada l2)
        {
            if (l1 is not null && l2 is not null)
            {
                return l1.Equals(l2);
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
