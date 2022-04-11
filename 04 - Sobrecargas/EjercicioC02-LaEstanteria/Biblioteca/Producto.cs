using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Producto: {p.marca}, precio: {p.precio}, codigo de barra: {(string)p}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.GetMarca() == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is  not null)
            {
                if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
