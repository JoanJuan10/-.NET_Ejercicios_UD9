using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ10
{
    class Serie
    {
        private string titulo;
        private int numeroTemporadas = 3;
        private bool entregado = false;
        private string genero;
        private string creador;

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
            this.creador = creador;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }
        public bool Entregado { get => entregado; set => entregado = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public void Main ()
        {
            Serie serie1 = new Serie();
            Serie serie2 = new Serie("Alacazam", "Yo");
            Serie serie3 = new Serie("RED", 1, "Accion", "Yo");



        }
    }
}
