using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.DatosContacto
{
    public class Cliente
    {
        public Cliente(DatosContacto datosContacto)
        {
            DatosContacto = datosContacto;
        }

        public DatosContacto DatosContacto { get; set; }
    }
}
