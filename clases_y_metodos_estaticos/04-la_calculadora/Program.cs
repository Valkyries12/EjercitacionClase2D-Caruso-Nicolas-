using biblioteca_de_clases;
using System;


namespace _04_la_calculadora
{
    /*
      Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

     Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

     Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

     Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.

         Este método devolverá true si el operando es distinto de cero.

     Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

     El usuario decidirá cuándo finalizar el programa.
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            string buffer;
            int primerOperando;
            int segundoOperando;
            bool noHayError;
            bool usuarioContinua;
            int resultado;

            primerOperando = 0;
            segundoOperando = 0;
            buffer = "";
            resultado = 0;
            usuarioContinua = false;
            do
            {
                Console.Write("Ingrese el primer operando: ");
                buffer = Console.ReadLine();
                noHayError = int.TryParse(buffer, out primerOperando);

                if (noHayError)
                {
                    Console.Write("Ingrese el segundo operando: ");
                    buffer = Console.ReadLine();
                    noHayError = int.TryParse(buffer, out segundoOperando);
                }
                else
                {
                    usuarioContinua = true;
                }

                if (noHayError)
                {
                    do
                    {
                        Console.Write("Ingrese la operacion [+, -, *, /]: ");
                        buffer = Console.ReadLine();

                        switch (buffer)
                        {
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                                resultado = Calculadora.Calcular(primerOperando, segundoOperando, buffer);
                                break;
                            default:
                                Console.WriteLine("ERROR. Solo se permite [+, -, *, /]. Reintente");
                                buffer = "true";
                                break;
                        }
                    } while (buffer == "true");


                }

                Console.WriteLine($"El resultado es: {resultado}");
                usuarioContinua = Validador.ValidarRespuesta();

            } while (usuarioContinua);

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
