using System;
using Biblioteca;

namespace EjercicioI01_Validador
{
    /* Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
       Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string auxNumero;
            int suma = 0;
            int contador = 0;
            int minimo = Int32.MaxValue;
            int maximo = Int32.MinValue;
            float promedio;


            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero: ");
                    auxNumero = Console.ReadLine();

                } while (!Int32.TryParse(auxNumero, out numero));

                if (Validador.Validar(numero, -100, 100))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                    contador++;
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("\nEl numero que ingreso no esta dentro del rango permitido");
                }
            }

            promedio = (float)suma / contador;

            Console.WriteLine($"De los num ingresados, {contador} estaban dentro del rango, de ellos: " +
                $"\nEl valor minimo es: {minimo}, el valor maximo es: {maximo} y el promedio es {promedio}");
        }
    }
}
