using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Validador
    {
        /// <summary>
        /// Valida un numero entero entre los rangos establecidos
        /// </summary>
        /// <param name="valor">numero entero</param>
        /// <param name="min">minimo valor ingresado</param>
        /// <param name="max">maximo valor ingresado</param>
        /// <returns>true si está dentro del rango establecido, de lo contrario false</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool resultado;

            resultado = false;
            if (valor > -101 && valor < 101 && min < max)
            {
                resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Valida dependiendo si se introdujo  S/N
        /// </summary>
        /// <returns>si se introdujo S (true), de lo contrario (false)</returns>
        public static bool ValidarRespuesta()
        {
            bool resultado;
            string respuestaUsuario;
            
            Console.Write("¿Desea continuar? (S/N): ");
            respuestaUsuario = Console.ReadLine();
            respuestaUsuario.ToLower();
            

            if (respuestaUsuario == "s")
            {
                resultado = true;
            } else
            {
                resultado = false;
            }

            return resultado;

        }
    }
}
