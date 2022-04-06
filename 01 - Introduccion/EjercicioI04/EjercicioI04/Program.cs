using System;

namespace EjercicioI04
{
    /*
     * Consigna#
        Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
        (excluido el mismo) que son divisores del número.
        El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        Escribir una aplicación que encuentre los 4 primeros números perfectos.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = int.MaxValue; 
            int contador = 0;

            for (int i = 1; i < numeros; i++) //itera los numeros de 1 a 10000
            {
                int suma = 0; //declaro un entero inicializado en 0 -> por cada i el contador vuelve a 0
                
                for (int k = 1; k < i; k++) 
                {
                    if (i % k == 0) // el resto de i/k debe ser 0 es decir es divisible
                    {
                        suma += k; //suma = suma + k -> se suman los numeros divisibles de i

                    }
                }
                if (suma == i && i != 1) //si la suma de los numeros divisibles de i es igual a i y no es 1
                {
                    Console.WriteLine($"Numero perfecto: {suma}");
                    contador++;
                    if(contador == 4)
                    {
                        break;
                    }
                }
            }

            Console.ReadKey();        }
    }
}
