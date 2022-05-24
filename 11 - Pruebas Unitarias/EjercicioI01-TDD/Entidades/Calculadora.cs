using System;

namespace Entidades
{
    public class Calculadora
    {
        
        public int Add(string numeros)
        {
            int total = 0;
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            char[] separadores = new char[] { '\n', ',' }; ;

            if (numeros.StartsWith("//"))//metodo que me dice si es true o false como comienza
            {
                numeros = numeros.Substring(3).Replace(numeros[2], ',');
            }
            
            foreach (string numero in numeros.Split(separadores))
            {
                if (int.Parse(numero) < 0)
                {
                    throw new NegativoNoPermitidoException(numero);
                }
                total += int.Parse(numero);
            }

            return total;
        }




    }
}
