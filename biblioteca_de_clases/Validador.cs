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
        /// valida si un valor es entero y esta entre los rangos indicados
        /// </summary>
        /// <param name="mensaje">mensaje a mostrar para la toma de datos</param>
        /// <param name="mensajeError">mensje de error en caso de que falle la toma de datos</param>
        /// <param name="pNumero">"puntero" donde se guardará el valor ingresado una vez validado</param>
        /// <param name="valorMinimo">minimo valor aceptado</param>
        /// <param name="valorMaximo">maximo valor aceptado</param>
        /// <param name="cantidadReintentos">cantidad maxima de reintentos</param>
        /// <returns>En caso de exito (true), de lo contrario (false)</returns>
        public static bool GetInt(string mensaje, string mensajeError, out int pNumero, int valorMinimo, int valorMaximo, int cantidadReintentos)
        {
            pNumero = 0;
            bool noHayError;
            string valorIngresado;

            noHayError = false;
            if (mensaje is not null && mensajeError is not null && valorMinimo < valorMaximo && cantidadReintentos > 0)
            {
                
                do
                {
                    cantidadReintentos--;
                    Console.Write(mensaje);
                    valorIngresado = Console.ReadLine();
                    if (EsNumericoInt(valorIngresado) && ValidarNumero(int.Parse(valorIngresado), valorMinimo, valorMaximo))
                    {
                        noHayError = int.TryParse(valorIngresado, out pNumero);
                        break;
                    }
                    else {
                        Console.WriteLine(mensajeError);
                    }

                } while (cantidadReintentos > 0);
            }

            return noHayError;
        }

        public static bool EsNumericoInt(string valor)
        {


            int numeroTipoInt;
            bool esNumerico;
            esNumerico = int.TryParse(valor, out numeroTipoInt);

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
            if (valor >= min && valor <= max && min < max)
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
