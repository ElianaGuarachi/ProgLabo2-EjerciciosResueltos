using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteca
{
    public class Torneo<T> where T: Equipo
    {
        private string nombre;
        private List<T> equipos;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                int num1;
                int num2;
                do
                {
                    num1 = random.Next(0, this.equipos.Count);
                    num2 = random.Next(0, this.equipos.Count);

                } while (num1 == num2);

                T equipo1 = equipos[num1];
                T equipo2 = equipos[num2];

                return CalcularPartido(equipo1, equipo2);
            }
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            if (torneo is not null && equipo is not null)
            {
                foreach (T item in torneo.equipos)
                {
                    if (item == equipo)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
           
            if (torneo is not null && equipo is not null)
            {
                if (torneo != equipo)
                {
                    torneo.equipos.Add(equipo);
                }
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo: {this.nombre} \n");
            foreach  (T equipos in this.equipos)
            {
                sb.AppendLine($"{equipos.Ficha()}");
            }
            sb.AppendLine("------------------------------");

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            
            int golEquipo1 = random.Next(0, 10);
            int golEquipo2 = random.Next(0, 10);
            
            return $"[{equipo1.Nombre}]: {golEquipo1} - " +
                $"[{equipo2.Nombre}]: {golEquipo2}";
        }



    }
}
