using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente2> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente2>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }


    }
}
