using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralitaa
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        public Centralitaa()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralitaa(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada item in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLlamada;
                        }
                        if (item is Provincial)
                        {
                            ganancia += ((Provincial)item).CostoLlamada;
                        }
                        break;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancias Locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias Provinciales: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancias Totales: {GananciasPorTotal}");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine($"Nro Destino: {llamada.NroDestino} - " +
                    $"Nro Origen: {llamada.NroOrigen} - Duracion: {llamada.Duracion}");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort((p, q) => Llamada.OrdenarPorDuracion(p, q));
        }






    }
}
