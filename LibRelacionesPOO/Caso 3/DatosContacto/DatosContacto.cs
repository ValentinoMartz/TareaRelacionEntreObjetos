using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_3.DatosContacto
{
    public class DatosContacto
    {


       public DatosContacto(string domicilio, int telefono, string email, Cliente cliente, Empleado empleado) {
            Domicilio= domicilio;
            Telefono= telefono; 
            Email= email;
            Cliente = cliente;
            Empleado = empleado;
        }

        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
    }
}
