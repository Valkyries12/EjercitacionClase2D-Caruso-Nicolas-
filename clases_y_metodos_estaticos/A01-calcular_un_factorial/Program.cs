using biblioteca_de_clases;
using System;

namespace A01_calcular_un_factorial
{
    /*
     El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él,
        por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

    En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            int factorial;
            int numeroIngresado;
            string buffer;
            bool noHayError;

            do
            {
                Console.Write("Ingrese un número: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    factorial = Calculadora.CalcularFactorial(numeroIngresado);
                    Console.WriteLine($"El factorial es: {factorial}");
                }
            } while (!noHayError);

            

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
