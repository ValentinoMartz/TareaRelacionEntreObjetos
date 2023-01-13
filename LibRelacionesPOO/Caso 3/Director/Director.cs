using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.Director
{
    public class Director
    {
        public Director(Clinica clinica) {
            Clinica = clinica;
        }
        public Clinica Clinica { get; set; }
    }
}
