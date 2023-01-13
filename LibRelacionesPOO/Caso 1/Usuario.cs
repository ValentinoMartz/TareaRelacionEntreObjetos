using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_1
{
    public class Usuario
    {
        public Usuario(string nombre, string password, Cliente cliente)
        {
            Nombre = nombre;
            Password = password;
            Cliente = cliente;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }
        public Cliente Cliente { get; set; }
    }
}
