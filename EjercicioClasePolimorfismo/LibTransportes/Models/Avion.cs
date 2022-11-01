using LibTransportes.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Avion : Transporte
    {
        #region constructores
        public Avion()
        {
        }

        public Avion(decimal maxAltitud, int nroMotores, decimal maxFuel, decimal velocidad, int maxCantPasajeros) : base(maxFuel, velocidad, maxCantPasajeros)
        {
            MaxAltitud = maxAltitud;
            NroMotores = nroMotores;
        }
        #endregion

        #region atributos
        public decimal MaxAltitud { get; set; }
        public int NroMotores { get; set; }

        #endregion

        #region metodos
        public override string acelerar()
        {
            return base.acelerar();
        }

        public override string desacelerar()
        {
            return base.desacelerar();
        }

        public string descender()
        {
            return "Descendiendo...";
        }

        public string ascender()
        {
            return "Ascendiendo...";
        }
        #endregion
    }
}
