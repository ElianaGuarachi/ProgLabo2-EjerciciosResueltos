using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool respuesta = false;
            if (valor >= min && valor <= max)
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
