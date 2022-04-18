using System;
using Biblioteca;

namespace EjercicioI02_ConsultarIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libros = new Libro();

            libros[1] = "Harry Potter y la piedra filosofal";
            libros[2] = "Harry Potter y camara secreta";
            libros[3] = "Harry Potter y el caliz de fuego";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(libros[i]);
            }

            libros[3] = "Harry Potter y el prisionero de Azkaban";
            
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(libros[i]);
            }

        }
    }
}
