using System;

namespace _07_pitagoras_estari_orgulloso
{
    /*
       Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

          El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

          Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

          Mostrar el resultado en la consola.
       */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            double baseTriangulo;
            double alturaTriangulo;
            bool noHayError;
            string buffer;
            double longitudHipotenusa;

            do
            {
                Console.Write("Ingrese la base del triangulo: ");
                buffer = Console.ReadLine();
                noHayError = double.TryParse(buffer, out baseTriangulo);

                if (noHayError && baseTriangulo > 0)
                {
                    Console.Write("Ingrese la altura del triangulo: ");
                    buffer = Console.ReadLine();
                    noHayError = double.TryParse(buffer, out alturaTriangulo);

                    if (noHayError)
                    {
                        longitudHipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
                        Console.WriteLine($"La longitud de la hipotenusa es: {longitudHipotenusa}");

                    }
                }
            } while (!noHayError);

            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

        }
    }
}
