using System;

namespace Entidades
{
    public class ParametrosVaciosException : Exception
    {
        
        public ParametrosVaciosException(string mensaje):base(mensaje)
        {

        }

        public ParametrosVaciosException(string mensaje, Exception inner):base(mensaje, inner)
        {

        }




    }
}
