using biblioteca_de_clases;
using System;

/*
 Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */
namespace _01_Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string respuestaUsuario;
            int minimoNumeroValidado;
            int maximoNumeroValidado;
            int cantidadNumerosValidados;
            int acumuladorNumerosValidados;
            int promedioNumerosValidados;
            int cantidadIngresos;

            minimoNumeroValidado = int.MaxValue;
            maximoNumeroValidado = int.MinValue;
            cantidadNumerosValidados = 0;
            cantidadIngresos = 10;
            acumuladorNumerosValidados = 0;

            do
            {
                Console.Write("Ingrese un número: ");
                respuestaUsuario = Console.ReadLine();

                if (int.TryParse(respuestaUsuario, out numeroIngresado))
                {
                    //logica para calcular y usar clase Validador
                    cantidadIngresos--;
                    if (Validador.Validar(numeroIngresado, -100, 100))
                    {
                        cantidadNumerosValidados++;
                        acumuladorNumerosValidados += numeroIngresado;

                        if (numeroIngresado < minimoNumeroValidado)
                        {
                            minimoNumeroValidado = numeroIngresado;
                        }
                        else if (numeroIngresado > maximoNumeroValidado)
                        {
                            maximoNumeroValidado = numeroIngresado;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Por favor reintente");
                }

            } while (cantidadIngresos != 0);

            promedioNumerosValidados = acumuladorNumerosValidados / cantidadNumerosValidados;
            Console.WriteLine(@$"
                                El maximo es: {maximoNumeroValidado}
                                El minimo es: {minimoNumeroValidado}
                                El promedio es: {promedioNumerosValidados}");
        }
    }
}
