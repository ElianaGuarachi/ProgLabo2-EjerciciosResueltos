using System;

namespace Entidades
{
    public class Sobrescrito
    {

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
