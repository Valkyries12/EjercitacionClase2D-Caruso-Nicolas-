using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Validador
    {
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
    }
}
