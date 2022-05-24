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

        public UnaExcepcion(string mensaje, Exception ex):base(mensaje,ex)
        {
        }

    }
}
