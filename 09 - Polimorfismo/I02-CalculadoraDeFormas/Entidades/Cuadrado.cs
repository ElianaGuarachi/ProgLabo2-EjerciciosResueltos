using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(float lado):base(lado, lado)
        {
            
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(this.longBase, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * this.longBase;
        }

    }
}
