using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Asistencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universidad universidad = new Universidad();
            int numeroEstudiantes;

            Console.Write("¿Cuántos estudiantes deseas registrar? ");
            while (!int.TryParse(Console.ReadLine(), out numeroEstudiantes) || numeroEstudiantes <= 0)
            {
                Console.Write("Por favor, ingresa un número válido de estudiantes: ");
            }

        }

    }
}
