using System;
using Biblioteca;

namespace EjercicioI01_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);

            Console.WriteLine($"La suma de los dos long {sumador.Sumar(45,2)}");
            Console.WriteLine($"La suma de los string es {sumador.Sumar("Hola", "mundo")}");

            int cantidadSumas = (int)sumador; //lo casteo a entero
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumador + sumadorB);

            Console.WriteLine(sumador | sumadorB);
            Console.WriteLine(sumador | sumadorC);




        }
    }
}
