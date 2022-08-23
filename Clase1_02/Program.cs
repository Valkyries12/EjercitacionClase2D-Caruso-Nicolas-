using System;

namespace Clase1_02
{
    internal class Program
    {
        //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
        //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        static void Main(string[] args)
        {
            bool codigoError;
            int numero;
            string buffer;
            int cuadrado;
            int cubo;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                buffer = Console.ReadLine();
                codigoError = int.TryParse(buffer, out numero);

                if (codigoError == false || numero < 1)
                {
                    Console.WriteLine("ERROR. !Reingresar número!");
                }

            } while (numero < 1 || codigoError == false);

            cubo = (int)Math.Pow(numero, 3);
            cuadrado = (int)Math.Pow(numero, 2);
            

            Console.WriteLine($"El cubo es: {cubo} {Environment.NewLine} El cuadraado es: {cuadrado}");
        }
    }
}
