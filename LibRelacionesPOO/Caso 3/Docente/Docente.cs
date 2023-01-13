using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.Docente
{
    public class Docente
    {
        public Docente(List<Alumno> alumno) {
            Alumno = alumno;
        }

        public List<Alumno> Alumnos { get; set; }
    }
}
