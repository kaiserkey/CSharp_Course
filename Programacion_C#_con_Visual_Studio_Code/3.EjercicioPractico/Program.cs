using System;
namespace _3.EjercicioPractico
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nombre, apellido, hobby;
            int edad;

            Console.Write("Introduce tu nombre/s: ");
            nombre = Console.ReadLine();
            Console.Write("Introduce tu apellido/s: ");
            apellido = Console.ReadLine();
            Console.Write("Introduce tu hobby/s: ");
            hobby = Console.ReadLine();
            Console.Write("Introduce tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==========INFORMACION BASICA==========");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Hobby: {hobby}");
            Console.WriteLine("=====================================");
        }
    }
}
