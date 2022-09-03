using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private List<Mascota> mascotas;

        public Cliente(string domicilio, string nombre, string apellido, string telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            mascotas = new List<Mascota>(); 
        }


        public string Nombre
        {
            get { return nombre; }
            set
            { 
                if (value != nombre)
                {
                    nombre = value;
                }
            }
        }

        public List<Mascota> Mascotas
        {
            get { return mascotas; }
        }

        public string ImprimirDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Domicilio: {domicilio}   Telefono: {telefono}");
            if (mascotas.Count > 0)
            {
                foreach (Mascota mascota in mascotas)
                {
                    sb.AppendLine($"{mascota.ImprimirDatos()}");
                }
                

            }
            sb.AppendLine("========================");

            return sb.ToString();
        }

    }


}
