using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        //constructores
        public Sumador():this(0) //constructor que no recibe parametros
        {
            
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2) //conversion implicita
        {
            return (int)s1 + (int)s2; //usa lo de arriba
        }

        /// <summary>
        /// Devuelve la suma de atributo canSumas
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator | (Sumador s1, Sumador s2)
        {
            return (int)s1 == (int)s2; //conversion explicita
        }

    }
}
