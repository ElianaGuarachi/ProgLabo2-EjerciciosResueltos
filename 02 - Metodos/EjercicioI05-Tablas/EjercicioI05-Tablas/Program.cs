using System;
using System.Text;

namespace EjercicioI05_Tablas
{
    /*
     Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string auxNumero;
   
            Console.WriteLine("\nIngrese el numero de la tabla que desee ver: ");
            auxNumero = Console.ReadLine();

            if(Int32.TryParse(auxNumero, out numero))
            {
                Multiplicar(numero);
            }
            else
            {
                Console.WriteLine("\nEl numero que ingreso no es valido");
            }

        }

        public static void Multiplicar(int numero)
        {
            StringBuilder stringB = new StringBuilder();
            int cuenta;

            Console.WriteLine($"\nTabla de multiplicar del número {numero}: ");
            for (int i = 1; i < 11; i++)
            {
                cuenta = numero * i;
                stringB.Append(Environment.NewLine);
                stringB.AppendFormat($"{numero} * {i} = {cuenta}");     
            }
            Console.WriteLine(stringB.ToString());
        }
    }
}
