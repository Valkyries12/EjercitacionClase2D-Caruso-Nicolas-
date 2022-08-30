using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return titular; }
        }

        public decimal Cantidad
        {
            get { return cantidad;}
        }


        public string Mostrar()
        {
            return $"Titular: {this.Titular} {Environment.NewLine} cantidad: {this.Cantidad}";
        }

        public void Ingresar(decimal nuevoMonto)
        {
            if (nuevoMonto > 0)
            {
                this.cantidad += nuevoMonto;
            }
        }

        public void Retirar(decimal montoARetirar)
        {
            this.cantidad = this.cantidad - montoARetirar;
            
        }
    }
}
