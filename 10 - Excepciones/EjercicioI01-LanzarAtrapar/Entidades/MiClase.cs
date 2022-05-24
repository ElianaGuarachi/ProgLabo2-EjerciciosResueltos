using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        int numero;

        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw;                
            }
        }

        public MiClase(int numero)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (Exception ex)
            {
                //
            }
        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("Excepcion en el metodo estatico");
        }
    }
}
