using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
        public double Promedio
        {
            get
            {
                if (Asignaturas == null || Asignaturas.Count == 0)
                {
                    return 0.0;
                }
                return Asignaturas.Average(a => a.Nota);
            }
        }
    }

    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
    }

    public static class DatosCompartidos
    {
        public static List<Estudiante> ListaEstudiantes { get; set; } = new List<Estudiante>();
        public static Estudiante EstudianteActual { get; set; }
    }
}
