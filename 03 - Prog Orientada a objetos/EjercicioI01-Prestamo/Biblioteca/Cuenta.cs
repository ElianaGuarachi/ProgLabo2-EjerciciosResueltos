using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular; //es privado para que no podamos acceder fuera de la clase
        private double cantidad; //es decir esta encapsulado

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        } //constructor de todos los atributos de esta clase

        //METODOS GETTERS PARA HACER PUBLICO LOS ATRIBUTOS
        public string GetTitular()
        {
            return titular;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        //NOS FORMATEA NUESTRO OBJETO DE FORMA ELEGIBLE
        public string Mostrar()
        {
            return $"El titular de la cuenta es: {GetTitular()}. Cantidad: {GetCantidad()}";
        }

        //METODOS PARA OPERAR
        public void Ingresar(double monto)
        {
            if(monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(double monto)
        {
            if(monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }

}
