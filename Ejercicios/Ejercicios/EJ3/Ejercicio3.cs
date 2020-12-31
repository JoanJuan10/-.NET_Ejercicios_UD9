using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ3
{
    class Ejercicio3
    {
        public void Ejercicio ()
        {
            Operaciones op1 = new Operaciones(3,5);

            Console.WriteLine("Suma: {0}", op1.CalcularSuma());
            Console.WriteLine("Resta: {0}", op1.CalcularResta());
            Console.WriteLine("Multiplicacion: {0}", op1.CalcularMultiplicacion());
            Console.WriteLine("Division: {0}", op1.CalcularDivision());

        }
    }
}
