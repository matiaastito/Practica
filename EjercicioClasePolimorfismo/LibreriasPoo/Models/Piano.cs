using LibreriasPoo.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasPoo.Models
{
    public class Piano : InstrumentoMusical
    {
        #region construc
        public Piano()
        {
        }

        public Piano(bool isElectronico, string modelo, string tipo) : base(modelo, tipo)
        {
            IsElectronico = isElectronico;
        }

        #endregion

        #region atributos
        public bool IsElectronico { get; set; }

        #endregion

        #region metodos
        public override string AfinarInstrumento()
        {
            return "Afinando " + this.GetType().Name;
        }

        #endregion
    }
}
