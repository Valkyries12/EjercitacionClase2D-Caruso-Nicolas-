using System;

namespace Clase1_02
{
    internal class Program
    {
        //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
        //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        static void Main(string[] args)
        {
            bool hayError;
            int numeroIngresado;
            string buffer;
            int cuadradoNumeroIngresado;
            int cuboNumeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                buffer = Console.ReadLine();
                hayError = int.TryParse(buffer, out numeroIngresado);

                if (hayError == false || numeroIngresado < 1)
                {
                    Console.WriteLine("ERROR. !Reingresar número!");
                }

            } while (numeroIngresado < 1 || hayError == false);

            cuboNumeroIngresado = (int)Math.Pow(numeroIngresado, 3);
            cuadradoNumeroIngresado = (int)Math.Pow(numeroIngresado, 2);
            

            Console.WriteLine($"El cubo es: {cuboNumeroIngresado} {Environment.NewLine} El cuadraado es: {cuadradoNumeroIngresado}");
        }
    }
}
