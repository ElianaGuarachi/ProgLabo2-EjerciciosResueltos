using System;
using Biblioteca;

namespace EjercicioI04_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string auxOperando1;
            string auxOperando2;
            string operacion;
            float operando1;
            float operando2;
            float resultado;
            
            do
            {
                Console.WriteLine("\nIngrese el primer operando: ");
                auxOperando1 = Console.ReadLine();

                if (float.TryParse(auxOperando1, out operando1))
                {
                    Console.WriteLine("\nIngrese el segundo operando: ");
                    auxOperando2 = Console.ReadLine();

                    if (float.TryParse(auxOperando2, out operando2))
                    {
                        Console.WriteLine("\nIngrese la operacion que desea realizar: (/ - * +)");
                        operacion = Console.ReadLine();

                        resultado = Calculadora.Calcular(operando1, operando2, operacion);

                        Console.WriteLine($"\nEl resultado de {operando1} {operacion} {operando2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("\nDebe ingresar un numero valido");
                    }
                }
                else
                {
                    Console.WriteLine("\nDebe ingresar un numero valido");
                }

                Console.WriteLine("\nDesea realizar otro calculo? si/no");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
        }
    }
}
