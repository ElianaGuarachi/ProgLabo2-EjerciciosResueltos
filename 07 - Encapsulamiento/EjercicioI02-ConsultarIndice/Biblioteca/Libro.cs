using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {

        private List<string> paginas;

        public Libro() //instanciar la lista
        {
            this.paginas = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < this.paginas.Count)
                {
                    return paginas[index];
                }
                return "Pagina no valida";
            }

            set
            {
                if(index > this.paginas.Count) //Uno mas de lo que hay
                {
                    this.paginas.Add(value); //se agrega
                }
                else if(index > 0)
                {
                    this.paginas.Insert(index,value); //seteo
                }
            }
        }





    }
}
