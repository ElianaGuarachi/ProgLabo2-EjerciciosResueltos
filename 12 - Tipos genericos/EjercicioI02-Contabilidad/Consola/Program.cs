using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo(1);
            Recibo recibo2 = new Recibo(2);
            Recibo recibo3 = new Recibo(3);

            Factura factura1 = new Factura(1);
            Factura factura2 = new Factura(2);
            Factura factura3 = new Factura(3);

            Contabilidad<Factura, Recibo> lista = new Contabilidad<Factura, Recibo>();

            lista += recibo1;
            lista += recibo2;
            lista += recibo3;
            lista += factura1;
            lista += factura2;
            lista += factura3;

            Console.WriteLine("Se agregaron a contabilidad");

            Console.ReadKey();

        }
    }
}
