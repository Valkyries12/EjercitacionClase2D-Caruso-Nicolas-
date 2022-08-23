using System;

namespace Clase1_04
{
    /*
     Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

    Escribir una aplicación que encuentre los 4 primeros números perfectos.

    2^n-1 (2^n-1) formul euclides
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //input positivo con un while hasta que encuentre los primeros 4 numerros perfecto
            int sumaDivisores;
            int cantidadNumeroPerfecto;
            int numeroAVerificar;

            sumaDivisores = 0;
            cantidadNumeroPerfecto = 0;
            numeroAVerificar = 6;

            do
            {
                for (int i = 1; i < numeroAVerificar; i++)
                {
                    if (numeroAVerificar % i == 0)
                    {
                        sumaDivisores += i;

                        if (sumaDivisores == numeroAVerificar)
                        {
                            Console.WriteLine(numeroAVerificar);
                            cantidadNumeroPerfecto++;
                        }
                    }

                }
                sumaDivisores = 0;
                numeroAVerificar++;
            } while (cantidadNumeroPerfecto != 4);
        }
    }
}
