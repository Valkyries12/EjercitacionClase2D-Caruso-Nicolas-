using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class CalculadoraDeArea
    {
        /// <summary>
        /// calcula el area de un cuadrado
        /// </summary>
        /// <param name="longitudLado">longitud de uno de sus lados</param>
        /// <returns>area del cuadraado</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado;
            areaCuadrado = longitudLado * longitudLado;

            return areaCuadrado;
        }

        /// <summary>
        /// calcula el area de un triangulo
        /// </summary>
        /// <param name="basee">longitud de la base</param>
        /// <param name="altura">altura del trinagulo</param>
        /// <returns>area del triangulo</returns>
        public static double CalcularAreaTriangulo(double basee, double altura)
        {
            double areaTringulo;
            areaTringulo = (basee * altura) / 2;

            return areaTringulo;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="radio">radio del circulo</param>
        /// <returns>area del circulo</returns>
        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo;
            areaCirculo = Math.PI * (radio * radio);

            return areaCirculo;
        }
    }
}
