using System;
using Biblioteca;

namespace EjercicioI03_EjemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El ejemplo universal";

            Estudiante e1 = new Estudiante("Guarachi", "112233", "Eliana");
            Estudiante e2 = new Estudiante("Gonzalez", "445566", "Elias");
            Estudiante e3 = new Estudiante("Guzman", "778899", "Ariel");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(7);

            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(8);

            e3.SetNotaPrimerParcial(3);
            e3.SetNotaSegundoParcial(4);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

            Console.ReadKey(); //ya no se necesita
        }
    }
}
