using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competidores: {this.competidores}");
            sb.AppendLine($"cantidad de Vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad competidores: {this.cantidadCompetidores}");

            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c - a;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.cantidadCompetidores > c.competidores.Count)
            {
                if (c != a)
                {
                    c.competidores.Add(a);
                    Random numero = new Random();
                    a.SetEnCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    a.SetCantidadCombustible((short)numero.Next(15, 100));

                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 miembros in c.competidores)
            {
                if (miembros == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }



    }
}
