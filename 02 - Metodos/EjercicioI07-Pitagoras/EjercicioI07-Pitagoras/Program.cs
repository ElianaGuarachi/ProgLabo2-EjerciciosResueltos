using System;

namespace EjercicioI07_Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxBase;
            string auxAltura;
            double hipotenusa;

            Console.WriteLine("\nIngrese la medida de la base del triangulo rectangulo (cateto 1): ");
            auxBase = Console.ReadLine();

            Console.WriteLine("\nIngrese la medida de la altura del triangulo rectangulo (cateto 2): ");
            auxAltura = Console.ReadLine();

            if (double.TryParse(auxBase, out double baseT) && double.TryParse(auxAltura, out double altura))
            {
                hipotenusa = Math.Sqrt(Math.Pow(baseT, 2) + Math.Pow(altura, 2));
                Console.WriteLine("\nEl valor de la hipotenusa es {0:N2}" ,hipotenusa);
            }
            else
            {
                Console.WriteLine("\nNo ingreso numeros validos");
            }
        }
    }
}
