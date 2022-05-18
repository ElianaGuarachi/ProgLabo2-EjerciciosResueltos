using System;

namespace Biblioteca
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this Int32 numero)
        {
            string resultado = string.Empty;

            if (numero % 3 == 0)
            {
                resultado += "Fizz";
            }

            if (numero % 5 == 0)
            {
                resultado += "Buzz";
            }

            if (string.IsNullOrEmpty(resultado))
            {
                resultado += numero.ToString();
            }

            return resultado;
        }


    }
}
