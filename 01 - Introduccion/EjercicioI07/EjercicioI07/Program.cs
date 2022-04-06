using System;

namespace EjercicioI07
{
    /*
     * Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas 
     * en el mes de N cantidad de empleados de una fábrica.
       Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
       hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
       Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados. 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            string auxHora;
            string nombre;
            string auxAntiguedad;
            string auxHorasTrabajadas;

            int horas;
            int antiguedad = -1;
            int horasTrabajadas;

            int cobroPorHoras;
            int cobroPorAntiguedad;
            int sueldoBruto;
            float descuentos;
            float totalCobro;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese su nombre y apellido: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine("\nIngrese el valor de la hora de trabajo: ");
                    auxHora = Console.ReadLine();

                    if (Int32.TryParse(auxHora, out horas) && horas > 0)
                    {
                        do
                        {
                            Console.WriteLine("\nIngrese la cantidad de anios de antiguedad: ");
                            auxAntiguedad = Console.ReadLine();

                            if (Int32.TryParse(auxAntiguedad, out antiguedad))
                            {
                                Console.WriteLine("\nIngrese la cantidad de horas trabajadas: ");
                                auxHorasTrabajadas = Console.ReadLine();

                                if (Int32.TryParse(auxHorasTrabajadas, out horasTrabajadas))
                                {
                                    cobroPorHoras = horas * horasTrabajadas;
                                    cobroPorAntiguedad = 150 * antiguedad;
                                    sueldoBruto = cobroPorAntiguedad + cobroPorHoras;
                                    descuentos = sueldoBruto * 0.13f;
                                    totalCobro = sueldoBruto - descuentos;

                                    Console.WriteLine("EMPLEADO \t VALOR HORA \t ANTIGUEDAD \t SUELDO BRUTO \t DESCUENTOS \t SUELDO NETO");
                                    Console.WriteLine($"{nombre} \t\t {horas} \t\t {antiguedad} \t\t {sueldoBruto} \t\t {descuentos} \t\t {totalCobro}");
                                }
                            }
                        } while (antiguedad < 0);
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar una cantidad de horas valida");
                    }
                } while (horas == 0);
                
            }

        }
    }
}
