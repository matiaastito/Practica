using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avioneta : VehiculoAereo
    {
        public Avioneta(string tipo, string trenAterrizaje, string modelo, decimal velmax, string motor, int alas, int turbinas, string combustible) : base(modelo, velmax, motor, alas, turbinas, combustible)
        {
            Tipo = tipo;
            TrenAterrizaje = trenAterrizaje;
        }

        public string Tipo { get; set; }
        public string TrenAterrizaje { get; set; }

    }
}
