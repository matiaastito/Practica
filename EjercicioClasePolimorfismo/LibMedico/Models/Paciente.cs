using LibMedico.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedico.Models
{
    public class Paciente : Persona
    {
        public Paciente()
        {
        }

        public Paciente(string nroHistoriaMedica, string nombre) : base(nombre)
        {
            NroHistoriaMedica = nroHistoriaMedica;
        }

        public string NroHistoriaMedica { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" + NroHistoriaMedica;
        }
    }
}
