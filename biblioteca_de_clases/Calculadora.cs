using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre los operandos en base el operador dado
        /// </summary>
        /// <param name="primerOperando">primer operando</param>
        /// <param name="segundoOperando">segundo operando</param>
        /// <param name="operacionMatematica">signo matematico para realizar el calculo</param>
        /// <returns>resultado segun el signo, si es erratico devuelve 0</returns>
        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            int resultado;

            resultado = 0;
            switch (operacionMatematica)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;
                default:
                    resultado = 0;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// valida que el segundo operando  no sea 0 
        /// </summary>
        /// <param name="segundoOperando"></param>
        /// <returns>true si no es cero, de lo contrario false</returns>
        private static bool Validar(int segundoOperando)
        {
            bool esValido;

            esValido = false;
            if (segundoOperando != 0 && segundoOperando > 0)
            {
                esValido = true;
            }

            return esValido;
        }
    }
}
