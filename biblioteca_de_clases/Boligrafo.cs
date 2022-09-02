using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Boligrafo
    {
        const int cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public short Tinta
        {
            get { return tinta; }

           private set
           { 
                //si aca valido que no se pase de 0 o 100 ¿como pinto los * con 3 de tinta restandole 10?
                if (tinta + value >= 0 && tinta + value <= cantidadTintaMaxima)
                {
                    tinta += value;
                }
           }
        }


        public ConsoleColor Color
        {
            get { return color; }
        }


        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool esDibujado;
            short tintaAnterior;

            tintaAnterior = Tinta;
            esDibujado = false;
            dibujo = "";
            Tinta = (short)(gasto *  -1);

            if (tintaAnterior != Tinta)
            {

                for (int i = 0; i < Math.Abs(gasto); i++)
                {
                    dibujo += "*";
                }
                esDibujado = true;
            }

            return esDibujado;
        }

    }
}
