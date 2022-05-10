using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia)
            :this(numero,escuderia,0)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            :base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");
            return sb.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1 is not null && a2 is not null &&
                a1.CantidadCombustible == a2.CantidadCombustible &&
                a1.Escuderia == a2.Escuderia &&
                a1.Numero == a2.Numero &&
                a1.EnCompetencia == a2.EnCompetencia &&
                a1.VueltasRestantes == a2.VueltasRestantes &&
                a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }



    }
}
