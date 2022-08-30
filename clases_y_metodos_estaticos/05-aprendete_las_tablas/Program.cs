using System;
using System.Text;

namespace _05_aprendete_las_tablas
{
    /*
     Crear una aplicación de consola que permita al usuario ingresar un número entero.

        Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

        Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

        Mostrar en la consola el resultado.

        Por ejemplo, si se ingresa el número 2 la salida deberá ser:

        Tabla de multiplicar del número 2:
        2 x 1 = 2
        2 x 2 = 4
        2 x 3 = 6
        2 x 4 = 8
        2 x 5 = 10
        2 x 6 = 12
        2 x 7 = 14
        2 x 8 = 16
        2 x 9 = 18
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            int numeroIngresado;
            string buffer;
            bool noHayError;
            string tablaMultiplicar;

            do
            {
                Console.Write("Ingrese un número: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    tablaMultiplicar = hacerTablaMultiplicar(numeroIngresado);
                    Console.WriteLine($"Tabla de multiplicar del número {numeroIngresado}");
                    Console.WriteLine(tablaMultiplicar);
                }

            } while (!noHayError);




            Console.WriteLine("=== FIN DEL PROGRAMA ===");

            string hacerTablaMultiplicar(int numero)
            {
                string resultadoFinal;

                resultadoFinal = "";
                for (int i = 1; i < 10 ; i++)
                {
                    StringBuilder resultadoTabla = new StringBuilder($"{numero} x {i} =  {numero * i}  ");
                    resultadoFinal += $"{resultadoTabla} {Environment.NewLine}";

                }

                return resultadoFinal;
            }

        }
    }
}
