using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibMedico.Models.Base
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        protected Persona(string nombre)
        {
            Nombre = nombre;
        }

        protected Persona()
        {
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
