using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz: IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            
            float tamanio = 0.1F;
            foreach (char item in texto)
            {
                ((IAcciones)this).UnidadesDeEscritura -= tamanio;
            }
            
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Este objeto es: {this.GetType().Name}\n" +
                $"Color de escritura: {((IAcciones)this).Color}\n" +
                $"Nivel de tinta: {((IAcciones)this).UnidadesDeEscritura}\n";
        }


    }
}
