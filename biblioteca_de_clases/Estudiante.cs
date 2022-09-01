using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public int NotaPrimerParcial
        {
            set { notaPrimerParcial = value; }
        }

        public int NotaSegundoParcial
        {
            set { notaSegundoParcial = value; }
        }

        private int CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        private int CalcularNotaFinal()
        {
            int notaFinal;

            notaFinal = -1;
            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                notaFinal = random.Next(6, 10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            int notaFinal;

            notaFinal = CalcularNotaFinal();
            StringBuilder sbDatosDelAlumno = new StringBuilder($"Nombre: {nombre}");
            sbDatosDelAlumno.AppendLine($"Apellido: {apellido}");
            sbDatosDelAlumno.AppendLine($"Legajo: {legajo}");
            sbDatosDelAlumno.AppendLine($"Primer parcial: {notaPrimerParcial}   Segundo Parcial: {notaSegundoParcial}");
            sbDatosDelAlumno.AppendLine($"Promedio: {CalcularPromedio()}");

            if (notaFinal > -1)
            {
                sbDatosDelAlumno.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sbDatosDelAlumno.AppendLine("Alumno desaprobado");
            }

                return sbDatosDelAlumno.ToString();
        }
    }
}
