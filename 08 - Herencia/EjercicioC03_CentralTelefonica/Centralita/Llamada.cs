using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {Duracion}");
            sb.AppendLine($"Nro Origen: {NroOrigen}");
            sb.AppendLine($"Nro Destino: {NroDestino}");
            
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1 is not null && llamada2 is not null)
            {
                return llamada1.Duracion.CompareTo(llamada2.Duracion);
                //if (llamada1.duracion > llamada2.duracion)
                //{
                //    return 1;
                //}
            }
            return -1;
        }







    }
}
