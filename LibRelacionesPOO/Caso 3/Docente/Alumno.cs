using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.Docente
{
    public class Alumno
    {

        public Alumno(Docente docente) {
            Docente = docente;
        }

        public Docente Docente { get; set; }
    }
}
