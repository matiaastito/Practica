using LibreriasPoo.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasPoo.Models
{
    public class Violin : InstrumentoMusical
    {
        #region construc
        public Violin()
        {
        }

        public Violin(string material, int cantCuerdas, string modelo, string tipo) : base(modelo, tipo)
        {
            Material = material; 
            CantCuerdas = cantCuerdas;  
        }

        #endregion

        #region atributos
        public string Material { get; set; }
        public int CantCuerdas { get; set; }

        #endregion

        #region metodos
        public override string AfinarInstrumento()
        {
            return "Afinando " + this.GetType().Name;
        }

        #endregion
    }
}
