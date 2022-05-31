using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>() 
            {
                new Persona("Alejandro", 35),
                new Persona("Esteban", 23),
                new Persona("Tomas", 41),
                new Persona("Pablo", 40),
                new Persona("Renzo", 26),
                new Persona("Franco", 20),
            };

            IEnumerable<Persona> personasElegidas = personas.Where(p => p.Edad == 48);

            Console.WriteLine(personas.Find(p => p.Edad == 33).ToString());

            personasElegidas.ToList().Find(p => p.Edad == 40).ToString();

            Comparison<Persona> comparador = (p1, p2) => p1.Edad - p2.Edad;

            personas.Sort(comparador);

            personas.ForEach(p => p.ToString());

            //foreach (Persona item in personas)
            //{
            //    Console.WriteLine(item.ToString());
            //}



            //Func<int, int> delegadoPotencia = CalcularPotenciaAlCuadrado;
            //Func<int, int> delegadoPotencia2 = n => n * n;

            ////Retorna un booleano
            //Predicate<int> predicate = numero => numero > 0;

            ////comparison retorna un entero
            //Comparison<int> comparador = (num1, num2) => num1 - num2;

            
        }


        static int CalcularPotenciaAlCuadrado(int numero)
        {
            return numero * numero;
        }
           

    }
}
