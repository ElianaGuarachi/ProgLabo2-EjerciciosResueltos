using System;

namespace Biblioteca
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float tamanio = 0.3F;
            foreach (char item in texto)
            {
                this.UnidadesDeEscritura -= tamanio;
            }

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        //un texto informando si es un lápiz o un bolígrafo, el color de escritura y el nivel de tinta
        public override string ToString()
        {
            return $"Este objeto es: {this.GetType().Name}\n" +
                $"Color de escritura: {this.Color}\n" +
                $"Nivel de tinta: {this.UnidadesDeEscritura}\n";
        }





    }
}
