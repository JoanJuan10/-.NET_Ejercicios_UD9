using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class Persona
    {
        private string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Saludar ()
        {
            Console.WriteLine("Hola, soy {0}", this.nombre);
        }
    }
}
