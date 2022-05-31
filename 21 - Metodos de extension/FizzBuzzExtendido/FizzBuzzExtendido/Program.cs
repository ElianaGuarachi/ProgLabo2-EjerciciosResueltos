using System;
using Biblioteca;

namespace FizzBuzzExtendido
{
    class Program
    {
        static void Main(string[] args)
        {
            


            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i.FizzBuzz()); //IntExtendido.FizzBuzz(i)
            }


            Console.ReadKey();
        }
    }
}
