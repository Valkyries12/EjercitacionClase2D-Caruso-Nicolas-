using biblioteca_de_clases;
using System;

namespace _03_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            Estudiante pepe = new Estudiante("Argento", "1234", "Pepe");
            Estudiante monica = new Estudiante("Argento", "321", "Monica");
            Estudiante paola = new Estudiante("Argento", "456", "Paola");

            pepe.NotaPrimerParcial = 7;
            pepe.NotaSegundoParcial = 6;
            monica.NotaPrimerParcial = 5;
            monica.NotaSegundoParcial = 4;
            paola.NotaPrimerParcial = 2;
            paola.NotaSegundoParcial = 1;

            Console.WriteLine(pepe.Mostrar());
            Console.WriteLine(monica.Mostrar());
            Console.WriteLine(paola.Mostrar());

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
