using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, int edad, string[] cursos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder stringB = new StringBuilder();

            stringB.AppendLine($"Nombre: {nombre}");
            stringB.AppendLine($"Edad: {edad}");
            stringB.AppendLine($"Direccion: {direccion}");
            stringB.AppendLine($"Genero: {genero}");
            stringB.AppendLine($"Pais: {pais}");
            stringB.AppendLine($"Cursos: ");
            foreach (string item in cursos)
            {
                stringB.AppendLine($"{item}");
            }

            return stringB.ToString();

        }
    }
}
