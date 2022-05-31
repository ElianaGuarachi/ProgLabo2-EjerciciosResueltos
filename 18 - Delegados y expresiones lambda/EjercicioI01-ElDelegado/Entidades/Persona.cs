using System;

namespace Entidades
{
    public class Persona
    {
        string nombre;
        int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Edad { get => this.edad; set => this.edad = value; }

        public override string ToString()
        {
            return $"{Nombre}, {Edad}";
        }
    }
}
