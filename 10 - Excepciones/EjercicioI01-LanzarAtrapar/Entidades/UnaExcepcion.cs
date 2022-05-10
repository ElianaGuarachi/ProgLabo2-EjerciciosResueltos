using System;

namespace Entidades
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion():base()
        {
            
        }

        public UnaExcepcion(string mensaje):base(mensaje)
        {

        }
    }
}
