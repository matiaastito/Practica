using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasPoo.Models.Base
{
    public abstract class InstrumentoMusical
    {
        #region construc
        protected InstrumentoMusical()
        {
        }

        protected InstrumentoMusical(string modelo, string tipo)
        {
            Modelo = modelo;
            Tipo = tipo;
        }

        #endregion

        #region atributos
        public string Modelo { get; set; }
        public string Tipo { get; set; }

        #endregion

        #region metodos
        public abstract string AfinarInstrumento();

        #endregion
    }
}
