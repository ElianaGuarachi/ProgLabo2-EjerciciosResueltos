using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

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

        private Jugador()
        {
           
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder stringB = new StringBuilder();

            stringB.AppendLine($"Nombre: {nombre}");
            stringB.AppendLine($"DNI: {dni}");
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
                if (j1.dni == j2.dni)
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
