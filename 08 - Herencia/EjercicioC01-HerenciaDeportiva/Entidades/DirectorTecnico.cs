using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }

        private DirectorTecnico(string nombre):base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Fecha de nacimiento: {FechaNacimiento}");
            return sb.ToString();

        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (dt1 is not null && dt2 is not null)
            {
                if (dt1.fechaNacimiento == dt2.fechaNacimiento)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }


    }
}
