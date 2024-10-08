using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Asistencia
{
    public class Universidad
    {
        private List<Estudiante> estudiantes;

        public Universidad()
        {
            estudiantes = new List<Estudiante>();
        }

        public void RegistrarEstudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
        {
            Estudiante nuevoEstudiante = new Estudiante(nombre, sesionesTotales);
            nuevoEstudiante.RegistrarAsistencia(sesionesAsistidas);
            estudiantes.Add(nuevoEstudiante);
        }

        public void MostrarResumen()
        {
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(ResumenEstudiante.ObtenerInfo(estudiante));
            }
        }
    }
}

