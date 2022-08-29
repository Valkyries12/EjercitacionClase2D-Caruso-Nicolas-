using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Calculadora
    {
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
