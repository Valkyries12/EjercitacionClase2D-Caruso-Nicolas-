using biblioteca_de_clases;
using System;
using System.Collections.Generic;

namespace maquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            string buffer;
            int numeroIngresado;
            bool noHayError;

            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();
            maquinaExpendedora.Add(1, new Producto("Tita", 50) );
            maquinaExpendedora.Add(2, new Producto("Rodesia", 70));
            maquinaExpendedora.Add(3, new Producto("Papas fritas", 75));
            maquinaExpendedora.Add(4, new Producto("Coca cola", 120));
            maquinaExpendedora.Add(5, new Producto("Pepsi", 115));
            maquinaExpendedora.Add(6, new Producto("7up", 125));
            maquinaExpendedora.Add(7, new Producto("Fanta", 119));
            maquinaExpendedora.Add(8, new Producto("Pebete", 100));
            maquinaExpendedora.Add(9, new Producto("Alfajor", 50));
            maquinaExpendedora.Add(10, new Producto("Galletitas", 65));


            foreach (KeyValuePair<int, Producto> dic in maquinaExpendedora)
            {
                Console.WriteLine($"{dic.Key} - {dic.Value.Nombre} - ${dic.Value.Precio}");
            }
            Console.WriteLine(Environment.NewLine);

            do
            {
                Console.Write("Ingrese un numero del 1 al 10: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out numeroIngresado);

                if (noHayError)
                {
                    Console.WriteLine($"Usted ha elegido {maquinaExpendedora[numeroIngresado].Nombre}");
                    Console.WriteLine(Environment.NewLine);

                    maquinaExpendedora.Remove(numeroIngresado);

                    foreach (KeyValuePair<int, Producto> dic in maquinaExpendedora)
                    {
                        Console.WriteLine($"{dic.Key} - {dic.Value.Nombre} - ${dic.Value.Precio}");
                    }
                    Console.WriteLine(Environment.NewLine);

                    Console.Write("Presione S para cerrar:  ");
                    buffer = Console.ReadLine().ToUpper();
                }
                else
                {
                    Console.WriteLine("Error. Reintente");
                    Console.WriteLine(Environment.NewLine);

                }

            } while (buffer != "S" || maquinaExpendedora.Count == 0);
            


            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
