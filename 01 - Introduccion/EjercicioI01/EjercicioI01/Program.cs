using System;

namespace EjercicioI01
{
    /* Ingresar 5 números por consola, guardándolos en una variable escalar. 
     * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     */
    class Program //se genera internamente
    {
        static void Main(string[] args) //punto de entrada, primer metodo que se ejecuta
        {
            
            int numero;
            int control = 1; //aumenta, al llegar a 5 se termina el bucle
            int acumulado = 0; //se suman los numeros ingresados
            float promedio;
            string auxString; //Aqui se almacena el numero ingresado
            int maximo = int.MinValue; //valor minimo -2174...
            int minimo = int.MaxValue; //valor maximo  2147...

            do
            {
                Console.WriteLine("Ingrese un numero:");
                auxString = Console.ReadLine(); //entrada de datos

                if (Int32.TryParse(auxString, out numero)) //cambia de string a numero
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    acumulado += numero;
                    control++;
                }
            } while (control <= 5);

            promedio = (float)acumulado / 5;

            Console.WriteLine("El valor maximo es: {0}. Valor minimo: {1}. Promedio {2}", maximo, minimo, promedio);
        }
    }
}
