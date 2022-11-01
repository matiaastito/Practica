using LibTransportes.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Auto :Transporte
    {

        #region constructores
        public Auto()
        {
        }

        public Auto(string modelo, decimal maxFuel, decimal velocidad, int maxCantPasajeros) : base(maxFuel, velocidad, maxCantPasajeros)
        {
            Modelo = modelo;
        }

        #endregion

        #region atributos
        public string Modelo { get; set; }

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

        public string doblarAIzq()
        {
            return "Doblando a la Izquierda..";
        }

        public string doblarADer()
        {
            return "Doblando a la Derecha..";
        }
        #endregion

    }
}
