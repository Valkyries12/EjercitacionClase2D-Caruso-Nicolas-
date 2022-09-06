using biblioteca_de_clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace maquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            /* string buffer;
             int numeroIngresado;
             bool noHayError;

             Queue<string> filaClientes = new Queue<string>();
             filaClientes.Enqueue("Roberto");
             filaClientes.Enqueue("Maria");
             filaClientes.Enqueue("Gabriel");
             filaClientes.Enqueue("Maximiliano");
             filaClientes.Enqueue("Jesica");


             Stack <Producto> titas = new Stack<Producto>();
             titas.Push(new Producto("Tita", 50));
             titas.Push(new Producto("Tita", 50));
             titas.Push(new Producto("Tita", 50));

             Stack<Producto> rodesias = new Stack<Producto>();
             rodesias.Push(new Producto("Rodesia", 70));
             rodesias.Push(new Producto("Rodesia", 70));
             rodesias.Push(new Producto("Rodesia", 70));

             Stack<Producto> papasFritas = new Stack<Producto>();
             papasFritas.Push(new Producto("Papas fritas", 75));
             papasFritas.Push(new Producto("Papas fritas", 75));
             papasFritas.Push(new Producto("Papas fritas", 75));








             Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
             maquinaExpendedora.Add(1, titas );
             maquinaExpendedora.Add(2, rodesias);
             maquinaExpendedora.Add(3, papasFritas);





             do
             {
                 Console.WriteLine($"Quedan {filaClientes.Count} clientes.\n");
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine($"Es el turno de {filaClientes.Peek()}\n");
                 Console.ResetColor();

                 foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                 {
                     Console.WriteLine($"{item.Key} - {item.Value.Peek().Nombre} - ${item.Value.Peek().Precio}");
                 }
                 Console.WriteLine(Environment.NewLine);

                 Console.Write("Ingrese una opción del 1 al 10: ");
                 buffer = Console.ReadLine();
                 noHayError = int.TryParse(buffer, out numeroIngresado);

                 if (noHayError && maquinaExpendedora.ContainsKey(numeroIngresado))
                 {
                     Producto productoElegido = maquinaExpendedora[numeroIngresado].Pop();
                     string clienteActual = filaClientes.Dequeue();

                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"{clienteActual} ha elegido {productoElegido.Nombre}. CÓDIGO [{productoElegido.CodigoProducto}] Valor: $ {productoElegido.Precio}  ");
                     Console.ResetColor();
                     Console.WriteLine(Environment.NewLine);

                     if (maquinaExpendedora[numeroIngresado].Count < 1)
                     {
                         maquinaExpendedora.Remove(numeroIngresado);

                     }



                 }
                 else
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Error. Reintente\n");
                     Console.ResetColor();
                     Console.WriteLine(Environment.NewLine);

                 }

                 if (filaClientes.Count == 0)
                 {
                     Console.WriteLine("No quedan más clientes.");
                 }

             } while (filaClientes.Count > 0 || maquinaExpendedora.Count == 0);



             Console.WriteLine("=== FIN DEL PROGRAMA ===");
            */




            
            int totalCuenta;
            int cantidadComidaElegida;
            Random random = new Random();
            StringBuilder sbComidasElegidas = new StringBuilder();

            cantidadComidaElegida = 2;
            totalCuenta = 0;
            List<Producto> mesaBuffet = new List<Producto>();

            Queue<string> filaClientes = new Queue<string>();
            filaClientes.Enqueue("Roberto");
            filaClientes.Enqueue("Maria");
            filaClientes.Enqueue("Gabriel");
            filaClientes.Enqueue("Maximiliano");
            filaClientes.Enqueue("Jesica");


            mesaBuffet.Add(new Producto("Totilla de papas", 250));
            mesaBuffet.Add(new Producto("Escalopes", 450));
            mesaBuffet.Add(new Producto("Pure de zapallo", 120));
            mesaBuffet.Add(new Producto("Pollo braseado", 378));
            mesaBuffet.Add(new Producto("Ensalada de atún", 300));
            mesaBuffet.Add(new Producto("Papas noissete", 210));





            do
            {
                Console.WriteLine($"Quedan {filaClientes.Count} clientes.\n");
                string clienteActual = filaClientes.Dequeue();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Es el turno de {clienteActual}\n");
                Console.ResetColor();

                foreach (Producto item in mesaBuffet)
                {
                    Console.WriteLine($"{item.Nombre} - ${item.Precio}");
                }
                Console.WriteLine(Environment.NewLine);


                sbComidasElegidas.AppendLine($"{clienteActual} ha elegido:\n");
                for (int i = cantidadComidaElegida; i > 0; i--)
                {
                    Producto productoElegido = mesaBuffet[random.Next(mesaBuffet.Count)];
                    sbComidasElegidas.AppendLine($"{productoElegido.Nombre} - {productoElegido.Precio}");
                    totalCuenta += productoElegido.Precio;
                }
                sbComidasElegidas.AppendLine($"\n TOTAL: $ {totalCuenta}\n\n");
                totalCuenta = 0;
              

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{sbComidasElegidas.ToString()}");
                sbComidasElegidas.Clear();
                Console.ResetColor();
                Console.WriteLine(Environment.NewLine);

  

                if (filaClientes.Count == 0)
                {
                    Console.WriteLine("No quedan más clientes.");
                }

            } while (filaClientes.Count > 0);


        }
    }
}
