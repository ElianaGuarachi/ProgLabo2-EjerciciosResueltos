using System;
using Biblioteca;

namespace ConsolaTorneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de futbol");

            EquipoFutbol f1 = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("San Lorenzo", DateTime.Now);

            EquipoBasquet b1 = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet b2 = new EquipoBasquet("Bulls", DateTime.Now);
            EquipoBasquet b3 = new EquipoBasquet("Equipox", DateTime.Now);

            torneoBasquet += b1;
            torneoBasquet += b2;
            torneoBasquet += b3;

            torneoFutbol += f1;
            torneoFutbol += f2;
            torneoFutbol += f3;

         
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine($"\nResultados del partido de basquet:\n");        
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine($"---------------------------------------");

            Console.WriteLine($"\nResultados del partido de futbol:\n");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}
