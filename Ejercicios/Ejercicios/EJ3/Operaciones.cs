using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ3
{
    class Operaciones
    {
        private int numero1;
        private int numero2;

        public Operaciones(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Numero1 { get => numero1; set => numero1 = value; }
        public int Numero2 { get => numero2; set => numero2 = value; }

        public int CalcularSuma ()
        {
            return this.numero1 + this.numero2;
        }
        public int CalcularResta()
        {
            return this.numero1 - this.numero2;
        }
        public int CalcularMultiplicacion()
        {
            return this.numero1 * this.numero2;
        }
        public double CalcularDivision()
        {
            return this.numero1 / this.numero2;
        }
    }
}
