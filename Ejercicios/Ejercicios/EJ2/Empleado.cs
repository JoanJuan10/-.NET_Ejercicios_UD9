using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ2
{
    class Empleado
    {
        private string nombre;
        private int sueldo;

        public Empleado(string nombre, int sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        public void ImprimirDatos()
        {
            Console.WriteLine("Mi nombre es {0}",this.nombre);
            Console.WriteLine("Mi sueldo es de {0}", this.sueldo);
        }
        public void PagarImpuestos()
        {
            if (this.sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
    }
}
