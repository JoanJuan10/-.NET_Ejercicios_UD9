using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class PruebaPersona
    {
        public void Main ()
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            p1.SetNombre("Alejandro");
            p2.SetNombre("Alonso");

            p1.Saludar();
            p2.Saludar();
        }
    }
}
