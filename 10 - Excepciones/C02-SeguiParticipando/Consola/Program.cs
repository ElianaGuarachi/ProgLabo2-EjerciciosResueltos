using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(10, 2, TipoCompetencia.F1);
            Competencia c2 = new Competencia(7, 2, TipoCompetencia.MotoCross);

            VehiculoDeCarrera a1 = new AutoF1(100, "Fitito", 200);
            VehiculoDeCarrera m1 = new MotoCross(666, "Moto guerrera", 4);

            if (c1 + a1)
            {
                //a1.CantidadCombustible = 125;
                //a1.EnCompetencia = true;
                //a1.VueltasRestantes = 4;
                Console.WriteLine(a1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            if (c2 + m1)
            {
                Console.WriteLine(m1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            AutoF1 a2 = new AutoF1(101, "Fitito 2", 123);
            MotoCross m2 = new MotoCross(667, "Moto 2", 2);

            if (c1 + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            if (c2 + m2)
            {
                Console.WriteLine(m2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            AutoF1 a3 = new AutoF1(102, "Fitito 3", 230);
            MotoCross m3 = new MotoCross(668, "Moto 35", 1);

            if (c1 + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }

            if (c2 + m3)
            {
                Console.WriteLine(m3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay lugar en la competencia");
            }
        }
    }
}
