using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models
{
    public class Torre : PiezaAjedrez
    {
        public Torre()
        {
        }

        public Torre(decimal tamaño, string material) : base(tamaño, material)
        {
        }

        public override string Mover()
        {
            return "Avanza hacia Adelante, Atras, Derecha o Izquierda";
        }
    }
}
