using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_de_clases
{
    public class Conductor
    {
        private static int id;
        private string nombre;
        private int[] kilometrosRecorridosEnCadaDiaSemana;
        private static Random random;

        public Conductor(string nombre)
        {
            id = id++;
            this.nombre = nombre;
            random = new Random();
            kilometrosRecorridosEnCadaDiaSemana = new int[6];
        }

        public Conductor()
        {
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Id
        {
            get { return id; }
        }

        public int[] KilometrosRecorridosEnCadaDiaSemana
        {
            get { return kilometrosRecorridosEnCadaDiaSemana; }
        }

        public void CalcularKmRecorridosEnCadaDiaSemana()
        {
            int indexFeriado;
            indexFeriado = random.Next(0,6);

            for (int i = 0; i < 6; i++)
            {
                if (i == indexFeriado)
                {
                    kilometrosRecorridosEnCadaDiaSemana[i] = 0;
                } else
                {
                    kilometrosRecorridosEnCadaDiaSemana[i] = random.Next(1, 500);
                }
            }
        }


    }
}
