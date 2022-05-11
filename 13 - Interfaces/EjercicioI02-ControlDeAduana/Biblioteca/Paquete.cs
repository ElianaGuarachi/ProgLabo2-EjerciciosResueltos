using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;


        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return costoEnvio * 0.35M;
            }
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso kg: {this.pesoKg}");
            sb.AppendLine($"Tiene prioridad: {this.TienePrioridad}");
            return sb.ToString();
        }

        public Paquete(string codigoSeguimiento, 
            decimal costoEnvio, string destino, 
            string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
            this.costoEnvio = costoEnvio;
        }
        




    }
}
