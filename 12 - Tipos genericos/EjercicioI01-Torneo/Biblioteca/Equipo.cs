using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Fecha
        {
            get { return this.fechaCreacion.ToShortDateString(); }
        }

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Nombre == e2.Nombre && e1.Fecha == e2.Fecha;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public virtual string Ficha()
        {
            return $"{this.Nombre} fundado el {this.Fecha}";
        }



    }
}
