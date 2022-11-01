using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public class Loro : Animal
    {
        public Loro()
        {
        }

        public Loro(string alimento, decimal peso, decimal altura, int edad) : base(peso, altura, edad)
        {
            Alimento = alimento;
        }

        public string Alimento { get; set; }

        public override string Imprimir()
        {
            return base.Imprimir();
        }

        public override string ImprimirComida()
        {
            return "Se alimenta de " + Alimento;
        }
    }
}
