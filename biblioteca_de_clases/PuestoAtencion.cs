using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{

    public enum EPuesto
    {
        Caja1,
        Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private EPuesto puesto;

        static  PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get 
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool AtenderCliente(Cliente2 cliente)
        {
            Thread.Sleep(4000);
            return true;
        }


    }
}
