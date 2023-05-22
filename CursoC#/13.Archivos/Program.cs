using System;
using System.IO;
namespace _13.Archivos
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Manejo de archivos en c# */

            TextWriter archivo = new StreamWriter("archivo.txt");

            Console.Write("Escribe la primera linea de texto: ");
            string mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);
            archivo.Close();
            Console.Clear();
            Console.WriteLine("Se ha guardado el archivo correctamente...");

            /* Leer un archivo en C# */
            TextReader reader = new StreamReader("archivo.txt");

            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            /* Agregar texto a un archivo en C# */

            StreamWriter archivo2 = File.AppendText("archivo.txt");
            Console.Write("Escribe la segunda linea de texto: ");
            mensaje = Console.ReadLine();
            archivo2.WriteLine(mensaje);
            archivo2.Close();

            TextReader reader2 = new StreamReader("archivo.txt");

            Console.WriteLine(reader2.ReadToEnd());
            reader2.Close();


        }
    }
}
