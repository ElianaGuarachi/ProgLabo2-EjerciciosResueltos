using System;
using Biblioteca;

namespace EjercicioI02_Prmaveras
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];

            personas[0] = new Persona("Eliana", new DateTime(1994,04,23), "38177868");
            personas[1] = new Persona("Ariel", new DateTime(1992,08,01), "35987654");
            personas[2] = new Persona("Elias", new DateTime(2005, 05, 06), "59123456");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Persona.Mostrar(personas[i]));
                Console.WriteLine(Persona.EsMayorDeEdad(personas[i]));
                Console.WriteLine("");
            }
        }
    }
}
