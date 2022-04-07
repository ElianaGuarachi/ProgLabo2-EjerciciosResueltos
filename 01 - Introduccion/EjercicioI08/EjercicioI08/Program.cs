using System;

namespace EjercicioI08
{
    /* Triangulo rectangulo. El usuario establece la altura.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            do
            {
                Console.WriteLine("\nIngrese la altura para el triangulo rectangulo");
                string auxAltura = Console.ReadLine();

                if (Int32.TryParse(auxAltura, out altura) && altura > 0)
                {
                    for (int i = 1; i < altura+1; i++)
                    {
                        Console.WriteLine(new string('*',i));
                    }
                }
                else
                {
                    Console.WriteLine("\nDebe ingresar un numero valido");
                }

            } while (altura > 0);
        }
    }
}
