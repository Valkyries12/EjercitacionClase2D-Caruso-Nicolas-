using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private List<string> vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new List<string>();
        }


        public string Especie
        {
            get { return especie; }
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

        public List<string> Vacunas
        {
            get { return vacunas; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento.ToLocalTime(); }
        }

        public string ImprimirDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Especie: {especie}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToLocalTime()}");
            if (vacunas.Count > 0)
            {
                foreach (string vacuna in vacunas)
                {
                    sb.Append($"{vacuna}");
                }
                sb.AppendLine();
                sb.AppendLine();
            } 
            else
            {
                sb.AppendLine("Sin vacuna");
            }

            return sb.ToString();
        }

    }
}
