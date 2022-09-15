using biblioteca_de_clases;
using System;

namespace _01_el_viajar_es_un_placer
{
    /*
     Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.

    Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
    Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
    Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
    Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
    Crearle a cada clase un constructor que reciba todos sus atributos.
    Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. Luego generar una relación de herencia entre ellas, según corresponda.
    VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
    Crear un proyecto de consola y generar el código necesario para probar las clases.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            Automovil auto = new Automovil(4, 4, EColores.ROJO, 50, 5);
            Camion camion = new Camion(6, 2, EColores.BLANCO, 76, 1500);
            Moto moto = new Moto(2, 0, EColores.AZUL, 760);


            Console.WriteLine("=== FIN DEL PROGRAMA ===");
        }
    }
}
