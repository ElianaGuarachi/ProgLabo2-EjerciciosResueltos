using System;

namespace EjercicioI03
{
    /*
     * Consigna
        Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        Validar que el dato ingresado por el usuario sea un número.
        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        Si ingresa "salir", cerrar la consola.
        Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string stringNumero;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                stringNumero = Console.ReadLine();

                if(int.TryParse(stringNumero, out int numero))
                {
                    for(int i = 2; i <= numero; i++)
                    {
                        int divisores = 0;
                        for (int d = 1; d<=i; d++)
                        {
                            if(i % d == 0)
                            {
                                divisores++;
                            }
                        }

                        if (divisores < 3)
                        {
                            Console.WriteLine("Numero primo: {0}",i);
                        }
                    }

                    Console.WriteLine("Usted desea ingresar otro numero? Escriba si o salir");
                    string respuesta = Console.ReadLine();
                    if(respuesta == "si")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    flag = true;
                }

            } while (flag == true);
        }
    }
}
