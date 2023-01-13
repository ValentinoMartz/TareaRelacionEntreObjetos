using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.Tripulacion
{
    public class Tripulacion
    {
        public Tripulacion(Azafata azafata)
        {
            Azafata = azafata;
        }

        public Azafata Azafata { get; set; }
    }
}
