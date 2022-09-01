using biblioteca_de_clases;
using System;

namespace _02_cuantas_primavera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            DateTime fechaNacimiento = new DateTime(1992, 06, 17);
            //YYYY/MM/DD
            Persona nicolas = new Persona("Diego", fechaNacimiento, "123456789");
            Console.WriteLine(nicolas.Mostrar());
            Console.WriteLine(nicolas.EsMayorDeEdad());

            fechaNacimiento = new DateTime(2000, 05, 21);
            Persona pepe = new Persona("Pepe", fechaNacimiento, "987654321");
            Console.WriteLine(pepe.Mostrar());
            Console.WriteLine(pepe.EsMayorDeEdad());

            fechaNacimiento = new DateTime(2015, 02, 05);
            Persona nancy = new Persona("Nancy", fechaNacimiento, "5566778899");
            Console.WriteLine(nancy.Mostrar());
            Console.WriteLine(nancy.EsMayorDeEdad());

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
