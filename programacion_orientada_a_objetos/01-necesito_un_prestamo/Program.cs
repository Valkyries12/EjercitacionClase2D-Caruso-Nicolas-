using biblioteca_de_clases;
using System;

namespace _01_necesito_un_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            string buffer;
            decimal monto;
            bool noHayError;
            string opcionMenu;

            Cuenta cuentaBancaria = new Cuenta("Pepe SA", 3500);
            opcionMenu = "";
            do
            {
                Console.Write($"{Environment.NewLine}1- Mostrar datos de la cuenta. {Environment.NewLine}2- Ingresar monto. {Environment.NewLine}3- Retirar dinero. {Environment.NewLine}4- Salir. {Environment.NewLine}{Environment.NewLine} Ingrese una opcion: ");
                opcionMenu = Console.ReadLine();
                

                switch (opcionMenu)
                {
                    case "1":
                        Console.Write(cuentaBancaria.Mostrar());
                        break;
                    case "2":
                        do
                        {
                            Console.Write("Ingrese el monto a depositar: ");
                            buffer = Console.ReadLine();
                            noHayError = decimal.TryParse(buffer, out monto);
                            if (noHayError)
                            {
                                cuentaBancaria.Ingresar(monto);
                                Console.WriteLine($"Se han ingresado $ {monto}");
                            }
                        } while (!noHayError);
                        break;
                    case "3":
                        do
                        {
                            Console.Write("Ingrese el monto a retirar: ");
                            buffer = Console.ReadLine();
                            noHayError = decimal.TryParse(buffer, out monto);
                            if (noHayError)
                            {
                                cuentaBancaria.Retirar(monto);
                                Console.WriteLine($"Se han debitado $ {monto}");
                            }
                        } while (!noHayError);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Reintente.");
                        break;
                }
            } while (opcionMenu != "4");


            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
