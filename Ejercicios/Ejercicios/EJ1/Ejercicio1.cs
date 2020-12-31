using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ1
{
    class Ejercicio1
    {
        public void Ejercicio()
        {
            Alumno al1 = new Alumno("Alejandro",18);

            Console.WriteLine("Me llamo {0} y tengo {1} de edad.", al1.Nombre, al1.Edad);
            if (al1.MayorEdad())
            {
                Console.WriteLine("Soy mayor de edad");
            }
            else
            {
                Console.WriteLine("No soy mayor de edad");
            }
        }
    }
}
