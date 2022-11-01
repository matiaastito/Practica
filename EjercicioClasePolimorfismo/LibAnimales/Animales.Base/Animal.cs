using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public abstract class Animal
    {
        
        public decimal Peso { get {
                return peso;
            } }
        public decimal Altura { get {
                return altura;
            } }
        public int Edad {
            get {
                return edad;
            }
        } 

        private int edad;
        private decimal altura;
        private decimal peso;
        protected Animal(decimal peso, decimal altura, int edad)
        {
            this.peso = peso;
            this.altura = altura;
            this.edad = edad;
        }

        protected Animal()
        {
        }

        public virtual string Imprimir()
        {
            return GetType().Name + "\n" + "Edad: " + Edad + "\nAltura: " + Altura + "\nPeso: " + Peso;
        }

        public abstract string ImprimirComida();
    }
}
