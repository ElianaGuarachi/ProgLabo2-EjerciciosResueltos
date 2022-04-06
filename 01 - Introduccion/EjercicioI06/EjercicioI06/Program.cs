using System;

namespace EjercicioI06

    /*
     * *Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también
        son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxNum1;
            string auxNum2;
            int num1;
            int num2;

            do
            {
                Console.WriteLine("\nIngrese el primer año: ");
                auxNum1 = Console.ReadLine();

                if (Int32.TryParse(auxNum1, out num1) && num1 > 0)
                {                  
                    do
                    {
                        Console.WriteLine("\nIngrese el segundo año: ");
                        auxNum2 = Console.ReadLine();

                        if (Int32.TryParse(auxNum2, out num2) && num2 > num1)
                        {
                            for (int i = num1; i <= num2; i++)
                            {
                                if (i % 4 == 0)
                                {
                                    if(i % 100 == 0)
                                    {
                                        if (i % 400 == 0 || i == 200)
                                        {
                                            Console.WriteLine($"{i} es un año bisiesto");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{i} es un año bisiesto");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nError, debe ingresar un numero o el segundo año debe ser mayor al primero");
                        }
                        
                    } while (num2 == 0 || num2 < num1);
                }
                else
                {
                    Console.WriteLine("\nError, debe ingresar un numero o un año valido");
                }
                
            } while (num1 <= 0);
        }
    }
}
