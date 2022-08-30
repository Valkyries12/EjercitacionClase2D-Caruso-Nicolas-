using biblioteca_de_clases;
using System;

namespace _06_calculadora_de_areas
{
    /*
      Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

     public double CalcularAreaCuadrado(double longitudLado) {}

     public double CalcularAreaTriangulo(double base, double altura) {}

     public double CalcularAreaCirculo(double radio) {}

     El ingreso de los datos como la visualización se deberán realizar desde el método Main().
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudLado;
            double baseTriangulo;
            double alturaTriangulo;
            double radio;
            bool noHayError;
            string buffer;



            Console.WriteLine("=== INICIO DEL PROGRAMA ===");
            //calculo area del cuadrado
            do
            {
                Console.Write("Ingrese longitud de uno de sus lados: ");
                buffer = Console.ReadLine();
                noHayError = double.TryParse(buffer, out longitudLado);

                if (noHayError && longitudLado > 0)
                {
                    Console.WriteLine($"El área del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(longitudLado)}");
                }
            } while (!noHayError);

            //calculo area del traingulo
            do
            {
                Console.Write("Ingrese la base del triangulo: ");
                buffer = Console.ReadLine();
                noHayError = double.TryParse(buffer, out baseTriangulo);

                if (noHayError && baseTriangulo > 0)
                {
                    Console.Write("Ingrese la altura del triangulo: ");
                    buffer = Console.ReadLine();
                    noHayError = double.TryParse(buffer, out alturaTriangulo);

                    if (noHayError)
                    {
                        Console.WriteLine($"El área del triangulo es: {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");

                    }
                }
            } while (!noHayError);


            //calculo area del circulo
            do
            {
                Console.Write("Ingrese radio del circulo: ");
                buffer = Console.ReadLine();
                noHayError = double.TryParse(buffer, out radio);

                if (noHayError && radio > 0)
                {
                    Console.WriteLine($"El área del circulo es: {CalculadoraDeArea.CalcularAreaCirculo(radio)}");
                }
            } while (!noHayError);


            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
