using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Producto
    {
        private string nombre;
        private int precio;
        public static int codigoProducto;

        public Producto(string nombre, int precio)
        {
            
            codigoProducto++;
            this.nombre = nombre;
            this.precio = precio;

        }


        public string Nombre
        {
            get { return nombre; }
        }

        public int Precio
        {
            get { return precio; }
        }

        public int CodigoProducto
        {
            get { return codigoProducto; }
        }
    }
}
