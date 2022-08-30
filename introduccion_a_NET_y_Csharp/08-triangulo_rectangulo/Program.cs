using System;

namespace _08_triangulo_rectangulo
{
    /*
      Escribir un programa que imprima por consola un triángulo como el siguiente:
     El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaUsuario;
            int alturaTriangulo;
            bool noHayError;

            do
            {
                Console.Write("Ingrese la altura del triangulo: ");
                respuestaUsuario = Console.ReadLine();
                noHayError = int.TryParse(respuestaUsuario, out alturaTriangulo);
            } while (!noHayError || alturaTriangulo < 1);

            for (int i = 1; i <= alturaTriangulo; i++)
            {
                for (int j = alturaTriangulo - i; j < alturaTriangulo; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
