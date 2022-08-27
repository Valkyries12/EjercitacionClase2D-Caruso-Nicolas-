using biblioteca_de_clases;
using System;

/*
 Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */
namespace _02_Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string buffer;
            int sumaNumerosIngresados;
            bool noHayError;
            bool usuarioContinua;

            sumaNumerosIngresados = 0;
            usuarioContinua = true;

            do
            {
                Console.Write("Ingrese un número: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    sumaNumerosIngresados += numeroIngresado;
                    usuarioContinua = Validador.ValidarRespuesta();
                } else
                {
                    usuarioContinua = true;
                    Console.WriteLine("Error. Reintente");
                }
            } while (usuarioContinua);

            Console.WriteLine($"La suma de todos lo números es: {sumaNumerosIngresados}");
        }
    }
}
