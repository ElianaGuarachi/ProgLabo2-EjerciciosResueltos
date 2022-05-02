using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    public class Centralita
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

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada item in Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            ganancia += item.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            ganancia += item.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        ganancia += item.CostoLlamada;
                        break;
                }
            }
            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancias Locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias Provinciales: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancias Totales: {GananciasPorTotal}");
            sb.AppendLine("----------------------------------------");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine($"{llamada.ToString()}");
                sb.AppendLine("----------------------------------------");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if (c is not null && llamada is not null)
            {
                foreach (Llamada item in c.listaDeLlamadas)
                {
                    if(item == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c is not null && nuevaLlamada is not null)
            {
                if (c != nuevaLlamada)
                {
                    c.AgregarLlamada(nuevaLlamada);
                }
            }
            return c;
        }


    }
}
