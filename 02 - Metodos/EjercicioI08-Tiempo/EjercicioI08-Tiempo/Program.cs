using System;

namespace EjercicioI08_Tiempo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nIngrese su fecha de nacimiento en el formato DD/MM/AAAA");
            string fechaNacimiento = Console.ReadLine();
            DateTime date = Convert.ToDateTime(fechaNacimiento);



            Console.WriteLine("Su fecha de nacimiento es: " + date.Day + " " + date.Month + " " + date.Year);

        }

        public static int ContarCantidadDeDias(DateTime date)
        {
           
            return 0;
        }
    }
}