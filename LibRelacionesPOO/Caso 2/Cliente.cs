using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_2
{
    public class Cliente
    {
        public Cliente(List<Pedido> pedidos) {
            Pedidos = pedidos;
        }
        public List<Pedido> Pedidos { get; set; }
    }
}
