using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio quieres ejecutar?");

            Console.WriteLine("1 = Ejercicio 1");
            Console.WriteLine("2 = Ejercicio 2");
            Console.WriteLine("3 = Ejercicio 3");
            Console.WriteLine("4 = Ejercicio 4");
            Console.WriteLine("5 = Ejercicio 5");
            Console.WriteLine("6 = Ejercicio 6");
            Console.WriteLine("7 = Ejercicio 7");
            Console.WriteLine("8 = Ejercicio 8");
            Console.WriteLine("9 = Ejercicio 9");
            Console.WriteLine("10 = Ejercicio 10");


            string ejercicio = Console.ReadLine();

            switch (ejercicio)
            {
                case "1":
                    EJ1.Ejercicio1 ej1 = new EJ1.Ejercicio1();
                    ej1.Ejercicio();
                    break;
                case "2":
                    EJ2.Ejercicio2 ej2 = new EJ2.Ejercicio2();
                    ej2.Ejercicio();
                    break;
                case "3":
                    EJ3.Ejercicio3 ej3 = new EJ3.Ejercicio3();
                    ej3.Ejercicio();
                    break;
                case "4":
                    EJ4.PruebaPersona ej4 = new EJ4.PruebaPersona();
                    ej4.Main();
                    break;
                case "5":
                    EJ5.Libro ej5 = new EJ5.Libro();
                    ej5.Main();
                    break;
                case "6":
                    EJ6.Coche ej6 = new EJ6.Coche();
                    ej6.Main();
                    break;
                case "7":
                    Console.WriteLine("Lectura de Clase en código.");
                    break;
                case "8":
                    EJ8.Password ej8 = new EJ8.Password();
                    ej8.Main();
                    break;
            }
        }
    }
}
