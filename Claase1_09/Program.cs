using System;

namespace Claase1_09
{
    /*
     Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********

    El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaUsuario;
            int alturaTriangulo;
            bool noHayError;
            int contadorMitadParaAtras;

            contadorMitadParaAtras = 0;

            do
            {
                Console.Write("Ingrese la altura del triangulo: ");
                respuestaUsuario = Console.ReadLine();
                noHayError = int.TryParse(respuestaUsuario, out alturaTriangulo);
            } while (!noHayError || alturaTriangulo < 1);

            for (int i = 1; i <= alturaTriangulo; i++)
            {
                //me crea de la mitad para atras
                contadorMitadParaAtras = i - 1;
                if (contadorMitadParaAtras != 0)
                {
                    while (contadorMitadParaAtras != i)
                    {
                        Console.Write("*");
                        contadorMitadParaAtras++;
                    }
                }
                

                //me crea de la mitad para adelante
                for (int j = alturaTriangulo - i; j < alturaTriangulo; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
    }
}
