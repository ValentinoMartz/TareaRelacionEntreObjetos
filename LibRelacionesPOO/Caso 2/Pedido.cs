﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso_2
{
    public class Pedido
    {
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
        }

          public Cliente Cliente { get; set; }
    }
}