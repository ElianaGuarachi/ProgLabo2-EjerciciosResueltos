using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1: VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
            base.CantidadCombustible = 0;
            base.VueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1 is not null && a2 is not null &&
                a1.Escuderia == a2.Escuderia &&
                a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
