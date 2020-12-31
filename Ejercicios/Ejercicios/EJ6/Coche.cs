using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ6
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public Coche()
        {
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public double Potencia { get => potencia; set => potencia = value; }

        public void Main ()
        {
            Coche car = new Coche();

            car.Marca = "BMW";
            car.Modelo = "Taugur";
            car.Cilindrada = 20;
            car.Potencia = 5.8;

            Console.WriteLine(car.Marca);
            Console.WriteLine(car.Modelo);
            Console.WriteLine(car.Cilindrada);
            Console.WriteLine(car.Potencia);

        }
    }
}
