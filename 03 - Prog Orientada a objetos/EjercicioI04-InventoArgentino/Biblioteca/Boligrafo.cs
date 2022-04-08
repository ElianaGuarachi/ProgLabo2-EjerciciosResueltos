using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            
            return false;
        }

        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta2)
        {

            if ((this.tinta + tinta2) >= 0 && (this.tinta + tinta2) <= cantidadTintaMaxima)
            {
                this.tinta += tinta2;
            }
        }


    }
}
