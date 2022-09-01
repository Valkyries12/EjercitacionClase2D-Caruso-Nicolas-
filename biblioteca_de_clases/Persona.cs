using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edadActual;
            edadActual = DateTime.Now.Year - fechaNacimiento.Year;

            return edadActual;
        }

        public string Mostrar()
        {
            return @$"
            Nombre: {nombre}
            Edad: {CalcularEdad(fechaNacimiento)}
            DNI: {dni}";
        }

        public string EsMayorDeEdad()
        {
            return CalcularEdad(fechaNacimiento) > 17 ? "Es mayor de edad." : "Es menor"; 
        }




    }
}
