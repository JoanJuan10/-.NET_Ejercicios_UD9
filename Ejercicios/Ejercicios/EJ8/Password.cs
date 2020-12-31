using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ8
{
    class Password
    {
        private int longitud = 8;
        private string contraseña;

        public Password()
        {
        }

        public Password(int longitud)
        {
            Random r = new Random();
            this.contraseña = "";

            for (int i = 0; i < this.longitud; i++)
            {
                contraseña += Convert.ToChar(Convert.ToInt32(26 * r.NextDouble() + 65)).ToString();
            }
            
        }
        public void Main() 
        {
            Password pass = new Password();
            Console.WriteLine("Contraseña: {0}", pass.contraseña);
        }
    }
}
