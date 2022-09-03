using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class EmpresaTransporte
    {
        private string nombre;
        private Conductor[] conductores;

        public EmpresaTransporte(string nombre, int cantidadDeConductores)
        {
            this.nombre = nombre;
            conductores = new Conductor[cantidadDeConductores];
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

        public Conductor[] Conductores
        {
            get { return conductores; }
        }


        public Conductor CalcularConductorConMasKm()
        {
            //como hago para no instanciar un obj y no me salga error al asignar al conductor en el if
            Conductor conductorConMasKilometraje = new Conductor();
            int mayorKilometraje;
            int acumuladorKilometros;

            mayorKilometraje = int.MinValue;
            acumuladorKilometros = 0;
            for (int i = 0; i < conductores.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    acumuladorKilometros += conductores[i].KilometrosRecorridosEnCadaDiaSemana[j];
                }

                if (acumuladorKilometros > mayorKilometraje)
                {
                    mayorKilometraje = acumuladorKilometros;
                    conductorConMasKilometraje = conductores[i];
                }
            }

            return conductorConMasKilometraje;
        }

        /// <summary>
        /// Calcula al conductor con mas kilometraje en el dia especificado
        /// </summary>
        /// <param name="dia">entero con el dia especificado  0 domingo, 1 lunes....6 sabado</param>
        /// <returns>Conductor obj</returns>
        public Conductor CalcularConductorConMasKmEnDia(int dia)
        {
            Conductor conductorConMasKilometraje = new Conductor();
            int mayorKilometraje;
            int kmConductorActual;

            mayorKilometraje = int.MinValue;
            for (int i = 0; i < conductores.Length; i++)
            {
                kmConductorActual = conductores[i].KilometrosRecorridosEnCadaDiaSemana[dia];
                if ( kmConductorActual > mayorKilometraje)
                {
                    mayorKilometraje = kmConductorActual;
                    conductorConMasKilometraje = conductores[i];
                }
            }

            return conductorConMasKilometraje;
        }
    }
}
