using System;

namespace _03_los_primos
{
    internal class Program
    {
        /*
         Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

        Validar que el dato ingresado por el usuario sea un número.

        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

        Si ingresa "salir", cerrar la consola.

        Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
         */
        static void Main(string[] args)
        {
            int numeroIngresado;
            string respuestaUsuario;
            bool noHayError;

            do
            {
                Console.Write("Ingrese un número o escriba [salir]: ");
                respuestaUsuario = Console.ReadLine();
                noHayError = int.TryParse(respuestaUsuario, out numeroIngresado);
                if (noHayError)
                {
                    for (int i = 1; i < numeroIngresado; i++)
                    {
                        if (esNumeroPrimo(i))
                        {
                            Console.WriteLine($"{i} ");
                        }
                    }
                    Console.Write("¿Desea volver a operar? [si/salir] : ");
                    respuestaUsuario = Console.ReadLine();
                }
            } while (respuestaUsuario == "si" || respuestaUsuario != "salir");


            bool esNumeroPrimo(int numeroIngresado)
            {
                bool resultado;
                int cantidadDivisiones;

                cantidadDivisiones = 0;
                resultado = true;
                for (int i = 1; i <= numeroIngresado; i++)
                {
                    if (numeroIngresado % i == 0)
                    {
                        cantidadDivisiones++;
                        if (cantidadDivisiones > 2)
                        {
                            resultado = false;
                            break;
                        }
                    }
                }




                return resultado;
            }
        }


    }
}
