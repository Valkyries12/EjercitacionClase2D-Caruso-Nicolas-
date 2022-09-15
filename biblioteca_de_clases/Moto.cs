using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Moto : VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private EColores color;
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cilindrada = cilindrada;
        }
    }
}
