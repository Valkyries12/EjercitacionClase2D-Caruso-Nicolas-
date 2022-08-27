using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Conversor
    {
        /// <summary>
        /// Convierte unn número entero a binario
        /// </summary>
        /// <param name="numeroEntero">Numero entero</param>
        /// <returns>retorna un numero binario en formato string</returns>
        public static string ConvertirDecimalAlBinario(int numeroEntero)
        {
            string resultadoTemporal;
            string resultadoFinal;
            int cociente;
            int dividendo;
            int resto;
            int divisionesHechas;

            divisionesHechas = 0;
            cociente = 0;
            dividendo = numeroEntero;
            resultadoTemporal = "";
            resultadoFinal = "";
            do
            {
                cociente = dividendo / 2;
                resto = dividendo % 2;
                resultadoTemporal += resto;
                dividendo = dividendo / 2;
                divisionesHechas++;
                if (dividendo <= 1)
                {
                    resultadoTemporal += dividendo;
                }
            } while (dividendo != 1);


            for (int i = divisionesHechas ; i >= 0; i--)
            {
                resultadoFinal += resultadoTemporal[i]; 
            }


            return resultadoFinal;
        }


        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="numeroEntero">numeroBinario en formato entero</param>
        /// <returns>numero convertido a decimal</returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string binarioString;
            double suma;
            int numeroDecimal;
            double exponente;

            binarioString = numeroEntero.ToString();
            exponente = binarioString.Length -1;
            suma = 0;
            for (int i = 0; i < binarioString.Length; i++)
            {
                if (binarioString[i] != '0')
                {
                    suma += Math.Pow(2, exponente);
                }
                exponente--;
            }

            numeroDecimal = (int) suma;
            return numeroDecimal;
        }
    }
}
