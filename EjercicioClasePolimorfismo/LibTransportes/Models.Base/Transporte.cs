using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Base
{
    public abstract class Transporte
    {

        #region constructores
        protected Transporte()
        {
        }

        protected Transporte(decimal maxFuel, decimal velocidad, int maxCantPasajeros)
        {
            MaxFuel = maxFuel;
            Velocidad = velocidad;
            MaxCantPasajeros = maxCantPasajeros;
        }

        #endregion

        #region atributos

        public decimal MaxFuel { get; set; }
        public decimal Velocidad { get; set; }
        public int MaxCantPasajeros { get; set; }

        #endregion

        #region metodos

        public virtual string acelerar()
        {
            return "Acelerando...";
        }

        public virtual string desacelerar()
        {
            return "Desacelerando...";
        }

        #endregion
    }
}
