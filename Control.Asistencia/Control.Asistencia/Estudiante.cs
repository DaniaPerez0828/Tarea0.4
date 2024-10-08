using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Asistencia
{
    public class Estudiante
    {
        public string Nombre { get; private set; }
        public int SesionesTotales { get; private set; }
        public int SesionesAsistidas { get; private set; }
    }

    public Estudiante(string nombre, int sesionesTotales)
    {
        nombre = nombre;
        sesionesTotales = sesionesTotales;
        SesionesAsistidas = 0;
    }
}
