using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToShortDateString();
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string GetDni()
        {
            return dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        private static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;

            return edad;
        }

        public static string Mostrar(Persona persona)
        {
            int edad = CalcularEdad(persona.fechaDeNacimiento);

            return $"{persona.GetNombre()} con DNI: {persona.GetDni()} y fecha de " +
                $"nacimiento el {persona.GetFechaDeNacimiento()}, tiene {edad} años.";
        }

        public static string EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona.fechaDeNacimiento);
            if (edad > 17)
            {
                return $"Es mayor de edad";
            }
            else
            {
                return $"Es menor de edad";
            }
        }

    }
}
