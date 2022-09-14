using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Cliente2
    {
        private string nombre;
        private int numero;

        public Cliente2(int numero)
        {
            this.numero = numero;
        }

        public Cliente2(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return numero; }
        }

    }
}
