﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ7
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private double peso;
        private double altura;


        public Persona()
        {
            const char sexoDefault = 'H';

            this.nombre = "";
            this.edad = 0;
            this.sexo = sexoDefault;
            this.peso = 0;
            this.altura = 0;

        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, string dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }


    }
}
