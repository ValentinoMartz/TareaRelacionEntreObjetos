using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_1
{
    public class Cliente
    {
        public Cliente(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }
        public Usuario Usuario { get; set; }
    }
}
