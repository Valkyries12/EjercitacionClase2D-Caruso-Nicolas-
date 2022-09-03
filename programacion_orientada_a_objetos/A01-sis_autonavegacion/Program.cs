using biblioteca_de_clases;
using System;

namespace A01_sis_autonavegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIO DEL PROGRAMA ===");

            Conductor conductorMasKilometro;
            Conductor conductorMasKilometroElMiercoles;
            Conductor conductorMasKilometroElViernes;

            EmpresaTransporte andreani = new EmpresaTransporte("Andreani", 3);

            andreani.Conductores[0] = new Conductor("Carlos");
            andreani.Conductores[1] = new Conductor("Pedro");
            andreani.Conductores[2] = new Conductor("Mariano");

            for (int i = 0; i < andreani.Conductores.Length; i++)
            {
                andreani.Conductores[i].CalcularKmRecorridosEnCadaDiaSemana();
            }

            conductorMasKilometro = andreani.CalcularConductorConMasKm();
            conductorMasKilometroElMiercoles = andreani.CalcularConductorConMasKmEnDia(3);
            conductorMasKilometroElViernes = andreani.CalcularConductorConMasKmEnDia(5);

            Console.WriteLine($"{conductorMasKilometro.Nombre} fué el que hizo mas kilometros en la semana");
            Console.WriteLine($"{conductorMasKilometroElMiercoles.Nombre} fué el que hizo mas kilometros el miercoles");
            Console.WriteLine($"{conductorMasKilometroElViernes.Nombre} fué el que hizo mas kilometros el viernes");

            Console.WriteLine("=== FIN DEL PROGRAMA ===");

        }
    }
}
