using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ5
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }

        public void Main()
        {
            Libro libro = new Libro();

            libro.Autor = "Armando";
            libro.Titulo = "Moby Dig";
            libro.Ubicacion = "America";

            Console.WriteLine(libro.Autor);
            Console.WriteLine(libro.Titulo);
            Console.WriteLine(libro.Ubicacion);
        }
    }
}
