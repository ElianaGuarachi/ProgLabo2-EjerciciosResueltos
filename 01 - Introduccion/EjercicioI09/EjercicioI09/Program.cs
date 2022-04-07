using System;

namespace EjercicioI09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            do
            {
                Console.WriteLine("Ingrese la altura para el triangulo equilatero");
                string auxAltura = Console.ReadLine();

                if (Int32.TryParse(auxAltura, out altura) && altura > 0)
                {
                    for (int i = 1; i <= altura; i++)
                    {
                        for (int j = 1; j <= altura - i; j++) //Deja espacios previos
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k < (i * 2); k++) //imprime los asteriscos
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero correcto");
                }
            } while (altura == 0);
        }
    }
}
