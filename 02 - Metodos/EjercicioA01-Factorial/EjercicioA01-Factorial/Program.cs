using System;

namespace EjercicioA01_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxNumero;
            uint numero;
            uint resultado;
            Console.WriteLine("CALCULO FACTORIAL");
            Console.WriteLine("\nIngrese un numero entero positivo: ");
            auxNumero = Console.ReadLine();
            if(UInt32.TryParse(auxNumero, out numero))
            {
               resultado = Factorial(numero);
                Console.WriteLine($"\nEl factorial de {numero} es {resultado}");
            }
            else
            {
                Console.WriteLine("\nUsted no ingreso un numero entero positivo");
            }
        }

        public static uint Factorial(uint numero)
        {
            uint resultado = 1;

            for (uint i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
