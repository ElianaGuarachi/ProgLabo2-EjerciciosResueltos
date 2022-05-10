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
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion);
        }

        public virtual string Ficha()
        {
            return $"{this.Nombre} fundado el {this.Fecha}";
        }



    }
}
