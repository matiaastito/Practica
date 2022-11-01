using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models
{
    public class Caballo : PiezaAjedrez
    {
        public Caballo()
        {
        }

        public Caballo(decimal tamaño, string material) : base(tamaño, material)
        {
        }

        public override string Mover()
        {
            return "Su movimiento es una L, ejemplo: avanza 1 hacia adelante y 2 hacia la derecha/izquierda";
        }
    }
}
