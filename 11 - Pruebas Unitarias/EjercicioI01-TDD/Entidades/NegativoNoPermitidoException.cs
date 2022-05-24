using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NegativoNoPermitidoException:Exception
    {
        public NegativoNoPermitidoException(string mensaje):base(mensaje)
        {

        }

        public NegativoNoPermitidoException(string mensaje, Exception inner):base(mensaje, inner)
        {

        }
    }
}
