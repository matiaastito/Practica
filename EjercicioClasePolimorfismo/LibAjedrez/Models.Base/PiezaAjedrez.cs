using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Base
{
    public abstract class PiezaAjedrez
    {
        protected PiezaAjedrez()
        {
        }

        protected PiezaAjedrez(decimal tamaño, string material)
        {
            Tamaño = tamaño;
            Material = material;
        }

        public decimal Tamaño { get; set; }
        public string Material { get; set; }

        public abstract string Mover();

    }
}
