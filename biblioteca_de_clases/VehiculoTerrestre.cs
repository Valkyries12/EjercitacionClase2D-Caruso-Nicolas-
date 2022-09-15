using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public abstract class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected EColores color;

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
