using System;
namespace _2.MensajesEnPantalla
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Esto es un texto que se imprime en una linea ");
            Console.Write("y este es otro texto que se imprime en la misma linea");

            Console.WriteLine("\nEsto es un texto que se imprime con un salto de linea");
            Console.WriteLine("Y este es otro texto que se imprime en la linea de abajo");

            /* ReadLine */
            Console.WriteLine("Introduce una linea de texto: ");
            string datos = Console.ReadLine();
            Console.WriteLine("Los datos que has introducido son: " + datos);
        }
    }
}
