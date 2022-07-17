using System;

namespace Entidades
{
    public delegate void DeledadoString(string msg);

    public class Persona
    {   
        private string apellido;
        private string nombre;

        public event DeledadoString EventoString;

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                if (EventoString is not null)
                {
                    EventoString.Invoke(nombre);
                }
            }
        }

        public string Apellido 
        {   get => apellido;
            set
            {
                apellido = value;
            } 
        }

        public string Mostrar()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

        public Persona()
        {

        }
    }
}
