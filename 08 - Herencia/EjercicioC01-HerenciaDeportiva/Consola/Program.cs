using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(4, "UTN");

            Jugador jugador1 = new Jugador(12456789, "Carlos", 5, 10);
            Jugador jugador2 = new Jugador(98765432, "Pedro", 4, 10);
            Jugador jugador3 = new Jugador(6543298, "Ana", 5, 14);
            Jugador jugador4 = new Jugador(45678932, "Soledad", 3, 10);

            DirectorTecnico director = new DirectorTecnico("Nicolas", DateTime.Today.Date);
            Console.WriteLine(director.MostrarDatos());

            if (equipo + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego al jugador");
            }

            if (equipo + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego al jugador");
            }

            if (equipo + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego al jugador");
            }

            if (equipo + jugador4)
            {
                Console.WriteLine(jugador4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego al jugador");
            }

        }
    }
}
