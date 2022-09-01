using biblioteca_de_clases;
using System;

namespace _02_cuantas_primavera
{
    /*
     Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

    Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni
    Deberá tener un constructor que inicialice todos los atributos.

    Construir los siguientes métodos para la clase:

    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.
     */
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
