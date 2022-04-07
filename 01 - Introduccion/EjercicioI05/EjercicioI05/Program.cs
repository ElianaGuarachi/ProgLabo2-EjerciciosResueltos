using System;

namespace EjercicioI05
{
    class Program
    {
        /*
         * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
           El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
           cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
           en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
           Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario 
           ingrese por consola. 
         * 
         */

        static void Main(string[] args)
        {
            int numero;
            int sumaAntesCentro = 0;
            int n = 1;
            int sumaDespuesCentro = 1;

            Console.WriteLine("Ingrese un numero: ");
            string stringNum = Console.ReadLine();

            do {
                
                if (Int32.TryParse(stringNum, out numero)) //convierte el string en numero -> Devuelve un bool
                {
                    for (int i = 1; i < n; i++) //i debe ser menor a n
                    {
                        sumaAntesCentro += i;

                    }

                    for (int k = n + 1; k < n * 2; k++)
                    {
                        if (sumaAntesCentro == sumaDespuesCentro)
                        {
                            Console.WriteLine($"Centro {n}");
                            break;
                        }
                        else
                        {
                            sumaDespuesCentro += k;
                        }
                    }
                }

                n++;
                sumaDespuesCentro = 0;
                sumaAntesCentro = 0;

            } while (numero > n);
        }
    }
}
