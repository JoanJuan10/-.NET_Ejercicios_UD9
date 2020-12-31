using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ9
{
    class Electrodomestico
    {
        private int precioBase = 100;
        private string color = "Blanco";
        private char consumo = 'F';
        private double peso = 5;

        public Electrodomestico(int precioBase, string color, char consumo, double peso)
        {
            this.precioBase = precioBase;
            if (color.ToLower() == "blanco" || color.ToLower() == "negro" || color.ToLower() == "rojo" || color.ToLower() == "azul" || color.ToLower() == "gris")
            {
                this.color = color;
            }
            else
            {
                Console.WriteLine("Color no valido. Asignado a Blanco");
            }
            this.consumo = consumo;
            this.peso = peso;
        }

        public Electrodomestico()
        {
        }

        public Electrodomestico(int precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public void Main ()
        {
            Electrodomestico el1 = new Electrodomestico();
            Electrodomestico el2 = new Electrodomestico(100, "Negro", 'A', 5);
            Electrodomestico el3 = new Electrodomestico(100,5);
            Electrodomestico el4 = new Electrodomestico(100, "Amarillo", 'A', 5);
        }
    }
}
