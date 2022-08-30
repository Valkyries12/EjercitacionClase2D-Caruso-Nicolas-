using System;

namespace _07_recibo_de_sueldo
{
    //Se debe pedir el ingreso por teclado del valor hora, el nombre,
    //la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

    //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
    //hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

    //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
    //el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaUsuario;
            int aniosTrabajados;
            int valorPorHora;
            int cantidadEmpleados;
            int horasTrabajadasEnElMes;
            string nombreTrabajador;
            bool noHayError;
            double sueldoBruto;
            double sueldoNeto;

            aniosTrabajados = 0;
            valorPorHora = 0;
            horasTrabajadasEnElMes = 0;
            nombreTrabajador = "";
            sueldoBruto = 0;
            sueldoNeto = 0;
            noHayError = false;

            Console.Write("Ingrese la cantidad de empledos: ");
            respuestaUsuario = Console.ReadLine();

            if (int.TryParse(respuestaUsuario, out cantidadEmpleados))
            {
                do
                {

                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        Console.Write("Ingrese nombre del empleado: ");
                        nombreTrabajador = Console.ReadLine();

                        Console.Write("Ingrese los años trabajados: ");
                        respuestaUsuario = Console.ReadLine();
                        noHayError = int.TryParse(respuestaUsuario, out aniosTrabajados);
                        if (noHayError)
                        {
                            Console.Write("Ingrese el valor por hora: ");
                            respuestaUsuario = Console.ReadLine();
                            noHayError = int.TryParse(respuestaUsuario, out valorPorHora);

                            if (noHayError)
                            {
                                Console.Write("Ingrese las horaas trabajadas en el mes: ");
                                respuestaUsuario = Console.ReadLine();
                                noHayError = int.TryParse(respuestaUsuario, out horasTrabajadasEnElMes);
                            }
                        }

                        if (!noHayError)
                        {
                            Console.WriteLine("Error al ingresar los datos. Reintente.");
                        }
                        else
                        {
                            sueldoBruto = (valorPorHora * horasTrabajadasEnElMes) + (aniosTrabajados * 150);
                            sueldoNeto = sueldoBruto * 0.87;
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine($"|   nombre: {nombreTrabajador}   Antiguedad: {aniosTrabajados}|");
                            Console.WriteLine($"|   Valor por hora: {valorPorHora}   |");
                            Console.WriteLine($"|   sueldo bruto: {sueldoBruto}   sueldo neto: {sueldoNeto}|");
                            Console.WriteLine("---------------------------------------------------------------");
                        }
                    }


                } while (!noHayError);
            }
            else
            {
                Console.WriteLine("Error , solo se permiten numeros.");
            }


        }
    }
}
