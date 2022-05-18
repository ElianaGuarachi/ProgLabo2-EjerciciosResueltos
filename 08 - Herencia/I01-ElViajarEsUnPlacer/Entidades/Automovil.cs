using System;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
                :base(cantidadRuedas, cantidadPuertas, color)        
        {
            
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
