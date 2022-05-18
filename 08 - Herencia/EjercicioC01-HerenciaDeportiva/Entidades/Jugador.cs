using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        
        private int partidosJugados;
        private int totalGoles;
        
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {

                return (float)this.TotalGoles / this.PartidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
           
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder stringB = new StringBuilder();

            stringB.AppendLine(base.Mostrar());
            stringB.AppendLine($"Partidos jugados: {partidosJugados}");
            stringB.AppendLine($"Total de goles: {totalGoles}");
            stringB.AppendLine($"Promedio de goles: {PromedioGoles}");
            stringB.AppendLine("");

            return stringB.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            {
                if (j1.Dni == j2.Dni)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
