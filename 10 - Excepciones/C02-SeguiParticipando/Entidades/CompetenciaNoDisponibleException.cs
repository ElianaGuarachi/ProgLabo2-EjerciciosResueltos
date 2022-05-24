using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class CompetenciaNoDisponibleException: Exception
    {
        protected string nombreClase;
        protected string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepcion en el metodo {0} de la clase {1}", NombreMetodo, NombreClase);
            sb.AppendFormat(this.Message);
            while (this.InnerException is not null)
            {
                sb.AppendFormat(this.InnerException.ToString());
            }
            return sb.ToString();
        }

    }
}
