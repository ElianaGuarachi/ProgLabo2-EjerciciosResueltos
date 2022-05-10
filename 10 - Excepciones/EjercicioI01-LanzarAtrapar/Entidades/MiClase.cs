using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {

        }

        

        static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
