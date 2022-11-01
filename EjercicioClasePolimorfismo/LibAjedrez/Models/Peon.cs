using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models
{
    public class Peon : PiezaAjedrez
    {
        public Peon()
        {
        }

        public Peon(decimal tamaño, string material) : base(tamaño, material)
        {
        }

        public override string Mover()
        {
            return "Avanza hacia adelante 1 o 2 casilleros";
        }
    }
}
