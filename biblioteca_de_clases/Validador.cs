using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Validador
    {

        public static bool EsNumerico(string valor)
        {
            int numero;
            bool esNumerico;
            esNumerico = int.TryParse(valor, out numero);

            return esNumerico;
        }

        /// <summary>
        /// Valida un numero entero entre los rangos establecidos
        /// </summary>
        /// <param name="valor">numero entero</param>
        /// <param name="min">minimo valor ingresado</param>
        /// <param name="max">maximo valor ingresado</param>
        /// <returns>true si está dentro del rango establecido, de lo contrario false</returns>
        public static bool ValidarNumero(int valor, int min, int max)
        {
            bool resultado;

            resultado = false;
            if (valor > min && valor < max && min < max)
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

            resultado = false;
            Console.Write("¿Desea continuar? (S/N): ");
            respuestaUsuario = Console.ReadLine();
            respuestaUsuario.ToLower();
            

            if (respuestaUsuario == "s")
            {
                resultado = true;
            }

            return resultado;

        }
    }
}
