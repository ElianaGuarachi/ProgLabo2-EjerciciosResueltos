using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores) //recorro la lista
                {
                    if (item == j) //sobrecarga == clase Jugador
                    {
                        return false;
                    }
                }

                e.jugadores.Add(j); //Agrego j a la lista
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}