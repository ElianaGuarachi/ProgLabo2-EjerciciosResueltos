using System;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return Math.Pow(longitudLado,2);
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            return baseTriangulo * altura / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
