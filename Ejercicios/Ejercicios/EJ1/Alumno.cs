using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ1
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public bool MayorEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
