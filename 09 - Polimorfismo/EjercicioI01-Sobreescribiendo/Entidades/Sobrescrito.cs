using System;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Pobrar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override String ToString()
        {
            return "Este es mi metodo ToString sobrescrito";
        }

        public override bool Equals(object obj)
        {
            Sobrescrito sobrescrito = obj as Sobrescrito;
            return sobrescrito is not null && this == (Sobrescrito)obj;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
