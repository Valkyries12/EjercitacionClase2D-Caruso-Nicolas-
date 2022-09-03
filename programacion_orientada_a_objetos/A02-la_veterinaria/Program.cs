using biblioteca_de_clases;
using System;

namespace A02_la_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            //cliente con un perro sin vacunar
            Cliente cliente1 = new Cliente("san lorenzo 123", "Pepe", "Argento", "123456789");
            cliente1.Mascotas.Add(new Mascota("perro", "Fatiga", new DateTime(2015, 02, 11)));

            // cliente con un gato con la vacuna Triple felina
            Cliente cliente2 = new Cliente("Las piedras 321", "Liliana", "Flamenco", "15231234");
            cliente2.Mascotas.Add(new Mascota("gato", "Pelusa", new DateTime(2020, 07, 18)));
            foreach (Mascota mascota in cliente2.Mascotas)
            {
                if (mascota.Nombre == "Pelusa")
                {
                    mascota.Vacunas.Add("Triple Felina");
                }
            }

            // cliente con un gato sin vacunas y un perro con la vacuna contra la rabia
            Cliente cliente3 = new Cliente("Alzaga 1234", "Marcelo", "Baez", "22334455");
            cliente3.Mascotas.Add(new Mascota("gato", "Volcan", new DateTime(2010, 09, 15)));
            cliente3.Mascotas.Add(new Mascota("perro", "Negro", new DateTime(2019, 06, 02)));
            foreach (Mascota mascota in cliente3.Mascotas)
            {
                if (mascota.Nombre == "Negro")
                {
                    mascota.Vacunas.Add("Contra la rabia");
                }
            }


            Console.WriteLine(cliente1.ImprimirDatos());
            Console.WriteLine(cliente2.ImprimirDatos());
            Console.WriteLine(cliente3.ImprimirDatos());

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
