using System;

namespace Clase1_05
{
    /*
     Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

        El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
        El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

        Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaUsuario;
            bool noHayError;
            int numeroIngresado;
            int sumaNumerosAnteriores;
            int sumaNumerosPosteriores;
            int centroNumerico;

            centroNumerico = 0;
            sumaNumerosAnteriores = 0;
            sumaNumerosPosteriores = 0;
            do
            {
                Console.Write("Ingrese un número: ");
                respuestaUsuario = Console.ReadLine();
                noHayError = int.TryParse(respuestaUsuario, out numeroIngresado);

            } while (numeroIngresado > 1 && noHayError == false);

            //hago que i sea centro 
            for (int i = 1; i <= numeroIngresado; i++)
            {

                //bucle inverso para sumar anteriores a i
                for (int k = 0; k < i; k++)
                {
                    sumaNumerosAnteriores += k;
                }

                //bucle paara sumar posteriores a i
                for (int j = i+1; j <= sumaNumerosAnteriores; j++)
                {
                    //si el siguiente es menor a la suma de anterioes lo acumulo
                    if (j < sumaNumerosAnteriores)
                    {
                        sumaNumerosPosteriores += j;
                    }

                    if (sumaNumerosPosteriores == sumaNumerosAnteriores)
                    {
                        centroNumerico = i;
                         
                    }
                }

                sumaNumerosAnteriores = 0;
                sumaNumerosPosteriores = 0;

                if (centroNumerico != 0)
                {
                    Console.WriteLine($"El centro numérico es: {centroNumerico}");
                    centroNumerico = 0;
                }
            }


            

           
        }
    }
}
