using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo: Figura
    {
        protected float longBase;
        protected float longAltura;

        public Rectangulo(float longBase, float longAltura)
        {
            this.longAltura = longAltura;
            this.longBase = longBase;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }


        public override double CalcularSuperficie()
        {
            return this.longBase * this.longAltura;
        }

        public override double CalcularPerimetro()
        {
            return (longBase + longAltura) * 2;
        }

    }
}
