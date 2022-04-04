using System;
using System.Text; //StringBuilder

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //Los UML no diferencian el candado como estatico o privado
        
        //CONSTRUCTOR ESTATICO
        static Estudiante() //Inicializa el atributo estatico random
        {
            random = new Random();
        }

        //CONSTRUCTOR CON PARAMETROS
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        //METODOS SETTERS
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        //METODOS DE CALCULO
        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11); //maximo es excluyente
            }
            return -1;
        }
        
        public float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float)this.notaSegundoParcial)/2;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            sb.AppendLine($"Nombre: {this.nombre}, Apellido: {this.apellido}, Legajo: {this.legajo}");
            sb.AppendLine($"Primer parcial: {this.notaPrimerParcial}, Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            if(notaFinal != -1)
            {
                sb.AppendLine($"Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }

            return sb.ToString();
        }
    }
}

