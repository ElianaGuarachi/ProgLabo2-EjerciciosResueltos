using System;
using Biblioteca;

namespace EjercicioI06_Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numero;
            do
            {
                Console.WriteLine("\nElija la figura geometrica para calcular el area: " +
                                                  "\n\t1- Cuadrado" +
                                                  "\n\t2- Triangulo" +
                                                  "\n\t3- Circulo");
                respuesta = Console.ReadLine();

                if(Int32.TryParse(respuesta, out numero))
                {
                    string auxLado;
                    string auxAltura;
                    double baseLado;
                    double altura;
                    double resultado;

                    switch (numero)
                    {
                        case 1:                           
                            Console.WriteLine("\nIngrese la medida del lado: ");
                            auxLado = Console.ReadLine();
                            if(double.TryParse(auxLado, out baseLado))
                            {
                                resultado = CalculadoraDeArea.CalcularAreaCuadrado(baseLado);
                                Console.WriteLine($"\nEl area del cuadrado es {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("\nDebe ingresar un numero");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\nIngrese la medida de la base del triangulo: ");
                            auxLado = Console.ReadLine();

                            Console.WriteLine("\nIngrese la medida de la altura del triangulo: ");
                            auxAltura = Console.ReadLine();

                            if (double.TryParse(auxLado, out baseLado) && double.TryParse(auxAltura, out altura))
                            {

                                resultado = CalculadoraDeArea.CalcularAreaTriangulo(baseLado, altura);
                                Console.WriteLine($"\nEl area del triangulo es {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("\nDebe ingresar un numero");
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nIngrese la medida del radio del circulo: ");
                            auxLado = Console.ReadLine();
                            if (double.TryParse(auxLado, out baseLado))
                            {
                                resultado = CalculadoraDeArea.CalcularAreaCirculo(baseLado);
                                Console.WriteLine($"\nEl area del circulo es {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("\nDebe ingresar un numero");
                            }
                            break;
                    }
                }

                Console.WriteLine("\nQuiere continuar? si / no");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
        }
    }
}
