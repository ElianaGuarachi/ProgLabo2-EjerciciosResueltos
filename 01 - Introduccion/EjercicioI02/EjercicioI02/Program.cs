using System;

namespace EjercicioI02
{
    /*  Consigna
        Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor
        que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            double potencia2;
            double potencia3;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();

                if (float.TryParse(numeroIngresado, out float numero) && numero > 0)
                {
                    potencia2 = Math.Pow(numero, 2);
                    potencia3 = Math.Pow(numero, 3);

                    Console.WriteLine("\nEl numero ingresado es {0}, su cuadrado es {1} y el cubo es {2}.", numero, potencia2, potencia3);

                    flag = false;
                }
                else
                {
                    Console.WriteLine("Error! Reingrese un numero");
                    flag = true;
                }

            } while (flag == true);
            

        }
    }
}
