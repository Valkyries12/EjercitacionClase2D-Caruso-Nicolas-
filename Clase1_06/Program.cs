using System;

namespace Clase1_06
{
    /*
     Escribir un programa que determine si un año es bisiesto.

    Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
    
    salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

    Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string anioDesdeStr;
            string anioHastaStr;
            int anioDesdeInt;
            int anioHastaInt;
            bool noHayError;

            anioHastaInt = 0;
            noHayError = false;
            do
            {
                Console.Write("Año desde: ");
                anioDesdeStr = Console.ReadLine();
                Console.Write("Año hasta: ");
                anioHastaStr = Console.ReadLine();

                if (int.TryParse(anioDesdeStr, out anioDesdeInt) && int.TryParse(anioHastaStr, out anioHastaInt) && anioDesdeInt < anioHastaInt)
                {
                    noHayError = true;
                } else
                {
                    Console.WriteLine("ERROR. Reintente");
                }

            } while (!noHayError);


            for (int anioActual = anioDesdeInt; anioActual <= anioHastaInt; anioActual++)
            {
                if (anioActual % 4 == 0 || anioActual % 400 == 0)
                {
                    Console.WriteLine(anioActual);
                }
            }
        }
    }
}
