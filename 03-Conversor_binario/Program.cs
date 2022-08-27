using biblioteca_de_clases;
using System;

namespace _03_Conversor_binario
{

    /*
     Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

    El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    public string ConvertirDecimalABinario(int numeroEntero) {}

    El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    public int ConvertirBinarioADecimal(int numeroEntero) {}


     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string buffer;
            bool noHayError;
            string numeroConvertidoABinario;
            int numeroConvertidoADecimal;

            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            
            do
            {
                Console.Write("Ingrese el número a convertir a binario: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    numeroConvertidoABinario = Conversor.ConvertirDecimalAlBinario(numeroIngresado);
                    Console.WriteLine($"{numeroIngresado} es : {numeroConvertidoABinario}");
                } else
                {
                    Console.WriteLine("Error. No es un número mayor a 0. Reitente.");
                }
            } while (numeroIngresado < 1 && !noHayError);


            do
            {
                Console.Write("Ingrese el número binario a convertir a decimal: ");
                buffer = Console.ReadLine();

                for (int i = 0; i < buffer.Length; i++)
                {
                    if (int.Parse(buffer[i].ToString()) > 1)
                    {
                        noHayError = false;
                        break;
                    }
                }
                //noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    numeroIngresado = int.Parse(buffer);
                    numeroConvertidoADecimal = Conversor.ConvertirBinarioADecimal(numeroIngresado);
                    Console.WriteLine($"{numeroIngresado} en decima es: {numeroConvertidoADecimal}");
                } else
                {
                    Console.WriteLine("Error. Solo numeros binarios. Reintente.");
                }
            } while (!noHayError);

            Console.WriteLine("=== FIN DEL PROGRAMA ===");
        }
    }
}
