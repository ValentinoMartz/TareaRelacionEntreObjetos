using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.DatosContacto
{
    public class DatosContacto
    {
       public DatosContacto(string domicilio, int telefono, string email) {
            Domicilio= domicilio;
            Telefono= telefono; 
            Email= email;
       
        }

        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
    }
}
