using System;
using Biblioteca;

namespace EjercicioI01_Prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";//Cambiar el nombre de la ventana

            //INSTANCIAR EL OBJETO
            Cuenta c1 = new Cuenta("Eliana Guarachi", 3000);

            //Console.WriteLine(c1.GetTitular());
            //Console.WriteLine(c1.GetCantidad());

            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(500);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(1200.50);
            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(2500);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(300.75);
            Console.WriteLine(c1.Mostrar());

            Console.ReadKey(); //Queda el puntero esperando, no se cierra el programa
        
        }
    }
}
