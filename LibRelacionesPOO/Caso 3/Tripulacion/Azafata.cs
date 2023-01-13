using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.Tripulacion
{
    public class Azafata
    {
        public Azafata(Tripulacion tripulacion) {
            Tripulacion = tripulacion;
        }

        public Tripulacion Tripulacion { get; set; }
    }
}
