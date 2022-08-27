using biblioteca_de_clases;
using System;


namespace _02_Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string buffer;
            int sumaNumerosIngresados;
            bool noHayError;
            bool usuarioContinua;

            sumaNumerosIngresados = 0;
            usuarioContinua = true;

            do
            {
                Console.Write("Ingrese un número: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    sumaNumerosIngresados += numeroIngresado;
                    usuarioContinua = Validador.ValidarRespuesta();
                } else
                {
                    usuarioContinua = true;
                    Console.WriteLine("Error. Reintente");
                }
            } while (usuarioContinua);

            Console.WriteLine($"La suma de todos lo números es: {sumaNumerosIngresados}");
        }
    }
}
