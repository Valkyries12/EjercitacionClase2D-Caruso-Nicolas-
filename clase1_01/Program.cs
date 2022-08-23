using System;

namespace clase1_01
{
    internal class Program
    {
        //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        static void Main(string[] args)
        {
            int numero;
            string buffer;
            bool codigoError;
            int max = 0;
            int min = 0;
            int promedio;
            int acum = 0;
            bool yaPaso = false;
            int i = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                buffer = Console.ReadLine();
                codigoError = int.TryParse(buffer, out numero);

                if (codigoError == true)
                {
                    i++;
                    acum += numero;
                    if (yaPaso == false)
                    {
                        max = numero;
                        min = numero;

                        yaPaso = true;

                    }
                    else
                    {
                        if (numero > max)
                        {
                            max = numero;
                        }

                        if (numero < min)
                        {
                            min = numero;
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Error al ingresar numero");
                }

            } while (i < 5);

            promedio = acum / 5;
            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"El maximo es: {max}");
            Console.WriteLine($"El minimo es: {min}");


        }
    }
}
