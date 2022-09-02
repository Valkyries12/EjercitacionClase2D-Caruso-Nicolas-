using biblioteca_de_clases;
using System;

namespace _04_invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            string dibujo;

            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);


            
            if (boligrafoAzul.Pintar(2, out dibujo))
            {
                Console.BackgroundColor = boligrafoAzul.Color;
                Console.WriteLine(dibujo);
            }

            boligrafoAzul.Recargar();

            if (boligrafoRojo.Pintar(5, out dibujo))
            {
                Console.BackgroundColor = boligrafoRojo.Color;
                Console.WriteLine(dibujo);
            }

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
