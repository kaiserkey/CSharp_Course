using System;
namespace _3.EjercicioPractico
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nombre, apellido, hobby;
            int edad;

            Console.Write("Introduce tu/s nombre/s: ");
            nombre = Console.ReadLine();
            Console.Write("Introduce tu/s apellido/s: ");
            apellido = Console.ReadLine();
            Console.Write("Introduce tu/s hobby/s: ");
            hobby = Console.ReadLine();
            Console.Write("Introduce tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==========INFORMACION BASICA==========");
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Hobby: {hobby}");
            Console.WriteLine("=====================================");
        }
    }
}
