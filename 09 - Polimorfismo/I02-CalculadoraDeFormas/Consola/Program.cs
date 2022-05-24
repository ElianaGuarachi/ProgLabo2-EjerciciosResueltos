using System;
using System.Collections.Generic;
using Entidades;
using System.Text;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaDeFiguras = new List<Figura>();

            listaDeFiguras.Add(new Circulo(3));
            listaDeFiguras.Add(new Cuadrado(5));
            listaDeFiguras.Add(new Rectangulo(4,3));

            StringBuilder sb = new StringBuilder();

            foreach (Figura figura in listaDeFiguras)//recorre la lista
            {
                sb.AppendLine();
                sb.AppendFormat("=============== FIGURA {0:0#} ==================\n", listaDeFiguras.IndexOf(figura) + 1);//indice de la lista
                sb.AppendFormat(" Tipo: {0}\n", figura.GetType());
                sb.AppendFormat(" {0}\n", figura.Dibujar());
                sb.AppendFormat(" Área: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat(" Perímetro: {0:0.00}\n", figura.CalcularPerimetro());
                sb.AppendLine("============================================");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();


        }
    }
}
