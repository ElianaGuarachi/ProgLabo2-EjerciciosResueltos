using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad <T,U> 
        where T: Documento
        where U: Documento, new()
    {
        private List<T> egresos;      
        private List<U> ingresos;


        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
            
        }

        //El operador + entre Contabilidad y T agrega un elemento a la lista egresos
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (c is not null && egreso is not null)
            {
                foreach  (T item in c.egresos)
                {
                    if (item != egreso)
                    {
                        c.egresos.Add(egreso);
                    }
                }
            }
            return c;
        }

        //El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c is not null && ingreso is not null)
            {
                foreach (U item in c.ingresos)
                {
                    if (item != ingreso)
                    {
                        c.ingresos.Add(ingreso);
                    }
                }
            }
            return c;
        }

        
    }
}
