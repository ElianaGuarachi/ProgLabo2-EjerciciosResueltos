using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(float operando1, float operando2, string operacion)
        {
            float resultado = float.NaN;

            switch(operacion)
            {
                case "*":
                    resultado = operando1 * operando2;
                    break;

                case "+":
                    resultado = operando1 + operando2;
                    break;

                case "-":
                    resultado = operando1 - operando2;
                    break;

                case "/":
                    if(Calculadora.Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                    }                    
                    break;
            }

            return resultado;
        }

        private static bool Validar(float operando2)
        {
            bool validacion = false;

            if(operando2 != 0)
            {
                validacion = true;
            }

            return validacion;
        }
    }
}
