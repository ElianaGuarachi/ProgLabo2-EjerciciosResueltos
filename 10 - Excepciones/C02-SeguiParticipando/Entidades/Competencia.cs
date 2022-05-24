using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1, MotoCross
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantVueltas;
            this.cantidadCompetidores = cantCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competidores: {this.competidores}");
            sb.AppendLine($"cantidad de Vueltas: {this.CantidadVueltas}");
            sb.AppendLine($"Cantidad competidores: {this.CantidadCompetidores}");
            sb.AppendLine($"Tipo de competencia: {this.Tipo}");

            return sb.ToString();
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            return c - a;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if (c.cantidadCompetidores > c.competidores.Count)
            {
                try
                {
                    if (c != a)
                    {
                        switch (c.Tipo)
                        {
                            case TipoCompetencia.F1:
                                if (a is AutoF1)
                                {
                                    c.competidores.Add(a);
                                }
                                break;
                            case TipoCompetencia.MotoCross:
                                if (a is MotoCross)
                                {
                                    c.competidores.Add(a);
                                }
                                break;
                        }

                        return true;
                    }
                }
                catch (CompetenciaNoDisponibleException ex)
                {
                    ex.InnerException.Message;
                }
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            try
            {
                foreach (VehiculoDeCarrera miembros in c.competidores)
                {
                    if(miembros != a)
                    {
                        throw new CompetenciaNoDisponibleException("El vehiculo no pertenece a la competencia", 
                            "Competencia", "public static bool operator ==" );
                    }
                    if (miembros == a)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
               //
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

    }
}
