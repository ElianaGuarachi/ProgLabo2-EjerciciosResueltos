using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculador
    {
        public static int Calcular(int num1, int num2)
        {
            int resultado = -1;
            if (num1 >= 0 && num2 > 0)
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

    }

}
