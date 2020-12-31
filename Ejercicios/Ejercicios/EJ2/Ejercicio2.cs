using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ2
{
    class Ejercicio2
    {
        public void Ejercicio ()
        {
            Empleado emp1 = new Empleado("Joan", 3000);
            emp1.ImprimirDatos();

            emp1.PagarImpuestos();
        }
    }
}
