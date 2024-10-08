using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Asistencia
{
    public static class Asistencia
    {
        private const double MINIMO_ASISTENCIA = 75;
        public static double CalcularPorcentaje(int asistidas, int totales)
        {
            if (totales == 0)
                return 0;
            return (double)asistidas / totales * 100;
        }
        public static bool CumpleMinimo(int asistidas, int totales)
        {
            double porcentaje = CalcularPorcentaje(asistidas, totales);
            return porcentaje >= MINIMO_ASISTENCIA;
        }
    }
}
