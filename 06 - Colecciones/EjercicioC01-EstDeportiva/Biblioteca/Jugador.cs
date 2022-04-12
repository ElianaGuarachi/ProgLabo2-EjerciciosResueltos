using System;
using System.Text;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            promedioGoles = (float)totalGoles / partidosJugados;
            return promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder stringB = new StringBuilder();

            stringB.AppendLine($"Nombre: {nombre}");
            stringB.AppendLine($"DNI: {dni}");
            stringB.AppendLine($"Partidos jugados: {partidosJugados}");
            stringB.AppendLine($"Total de goles: {totalGoles}");
            stringB.AppendLine($"Promedio de goles: {promedioGoles}");
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
