using System;
using Entidades;

namespace EjercicioC02_EnciendanMotores
{
    public class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(10, 2);

            AutoF1 a1 = new AutoF1(100, "Fitito");
            Console.WriteLine(a1.MostrarDatos());
            if (c1 + a1)
            {
                Console.WriteLine(a1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            AutoF1 a2 = new AutoF1(101, "Fitito 2");
            Console.WriteLine(a2.MostrarDatos());
            if (c1 + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            AutoF1 a3 = new AutoF1(102, "Fitito 3");
            Console.WriteLine(a3.MostrarDatos());
            if (c1 + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }






        }
    }
}
