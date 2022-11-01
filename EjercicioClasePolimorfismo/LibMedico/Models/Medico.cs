using LibMedico.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedico.Models
{
    public class Medico : Persona
    {
        public Medico()
        {
        }

        public Medico(string especialidad, string nombre) : base(nombre)
        {
            Especialidad = especialidad;    
        }

        public string Especialidad { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" + Especialidad;
        }
    }
}
