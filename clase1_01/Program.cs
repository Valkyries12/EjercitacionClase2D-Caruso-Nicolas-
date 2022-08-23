using System;

namespace clase1_01
{
    internal class Program
    {
        //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        static void Main(string[] args)
        {
            int numeroIngresado;
            string buffer;
            bool noHayError;
            int maximoNumeroIngresado = 0;
            int minimoNumeroIngresado = 0;
            int promedioNumeroIngresado;
            int acumulaadorNumeroIngresado = 0;
            bool primerIteracion = false;
            int iteracion = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    iteracion++;
                    acumulaadorNumeroIngresado += numeroIngresado;
                    if (primerIteracion == false)
                    {
                        maximoNumeroIngresado = numeroIngresado;
                        minimoNumeroIngresado = numeroIngresado;

                        primerIteracion = true;

                    }
                    else
                    {
                        if (numeroIngresado > maximoNumeroIngresado)
                        {
                            maximoNumeroIngresado = numeroIngresado;
                        }

                        if (numeroIngresado < minimoNumeroIngresado)
                        {
                            minimoNumeroIngresado = numeroIngresado;
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Error al ingresar numero");
                }

            } while (iteracion < 5);

            promedioNumeroIngresado = acumulaadorNumeroIngresado / 5;
            Console.WriteLine($"El promedio es: {promedioNumeroIngresado}");
            Console.WriteLine($"El maximo es: {maximoNumeroIngresado}");
            Console.WriteLine($"El minimo es: {minimoNumeroIngresado}");


        }
    }
}
