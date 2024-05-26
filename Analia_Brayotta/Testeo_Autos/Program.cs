using System.Drawing;
using Libreria_Auto;

namespace Testeo_Autos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto autoUno = new Auto("Honda", 60, Color.Beige);

            Console.WriteLine(autoUno.ToString());

            ///F. En un proyecto de consola crear un objeto del tipo Auto, mostrar todos su valores y dentro de un bucle repetitivo 
            ///usar el metodo avanzar(), este debera repetirse hasta que el auto agote su combustible y se debera informar cuantas 
            ///repeticiones logra realizar.

            int repeticiones = 0;
            while (autoUno.Avanzar(23))
            {
              repeticiones++;
              
            }

            Console.WriteLine($"El auto logró realizar {repeticiones} repeticiones.");

        }
    }
}
