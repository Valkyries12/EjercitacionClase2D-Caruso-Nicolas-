using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace _02_numeros_locos_II
{
    /*
     Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

        Mostrar la colección tal como fue cargada.
        Luego mostrar los positivos ordenados en forma decreciente.
        Por último, mostrar los negativos ordenados en forma creciente.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            List<int> numeros = new List<int>();
            List<int> positivosDesc = new List<int>();
            List<int> negativosAsc = new List<int>();
            Stack<int> pilaDeNumeros = new Stack<int>();
            Queue<int> filDeNumeros = new Queue<int>();
            Random random = new Random();

            int numeroAIngresar;


            for (int i = 0; i < 20; i++)
            {
                do
                {

                    numeroAIngresar = random.Next(-20, 20);
                    if (numeroAIngresar != 0)
                    {
                        numeros.Add(numeroAIngresar);
                        pilaDeNumeros.Push(numeroAIngresar);
                        filDeNumeros.Enqueue(numeroAIngresar);
                        if (numeroAIngresar < 0)
                        {
                            negativosAsc.Add(numeroAIngresar);
                        }
                        else
                        {
                            positivosDesc.Add(numeroAIngresar);
                        }
                    }

                } while (numeroAIngresar == 0);
            }

            Console.WriteLine("Se muestran tal cual estan");
            Console.WriteLine("LIST");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);

            }

            Console.WriteLine("STACK");
            foreach (int num in pilaDeNumeros)
            {
                Console.WriteLine(num);

            }


            Console.WriteLine("QUEUE");
            foreach (int num in filDeNumeros)
            {
                Console.WriteLine(num);

            }

            Console.WriteLine("\nSe muestran positivos de forma descendente");
            positivosDesc.Sort();
            positivosDesc.Reverse();
            foreach (int num in positivosDesc)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nSe muestran negativos de forma ascendente");
            negativosAsc.Sort();

            foreach (int num in negativosAsc)
            {
                Console.WriteLine(num);
            }

            




            Console.WriteLine("=== FIN DEL PROGRAMA ===");
        }
    }
    
}
