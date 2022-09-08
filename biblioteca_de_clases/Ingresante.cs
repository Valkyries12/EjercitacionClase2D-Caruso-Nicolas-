using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Ingresante
    {
        private List<string> cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(List<string> cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder($"Nombre: {this.nombre}\n");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine("Curso/s: ");
            if (this.cursos.Count > 0)
            {
                foreach (string curso in cursos)
                {
                    sb.AppendLine(curso);
                }
            }

            return sb.ToString();
        }
    }
}
