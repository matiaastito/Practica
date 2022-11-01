using LibreriasPoo.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasPoo.Models
{
    public class Guitarra : InstrumentoMusical
    {
        #region construc
        public Guitarra()
        {
        }

        public Guitarra(string material, bool isAcustica, string modelo, string tipo) : base(modelo, tipo)
        {
            Material = material;
            IsAcustica = isAcustica;    
        }

        #endregion

        #region atributos
        public string Material { get; set; }
        public bool IsAcustica { get; set; }

        #endregion

        #region metodos
        public override string AfinarInstrumento()
        {
            return "Afinando " + this.GetType().Name;
        }

        #endregion
    }
}
