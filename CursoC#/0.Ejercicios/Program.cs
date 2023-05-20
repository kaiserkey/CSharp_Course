using System;
namespace _0.Ejercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            /* 
                a. Implementa tu programa en un proyecto de consola llamado arreglos.cs.
                b. Crea cuatro arreglos dónde se almacene: nombre, apellido, edad, sexo.
                c. Crea los arreglos con los siguientes nombres: arreglo_n, arreglo_a, arreglo_e, arreglo_s.
                d. Imprima los arreglos en el orden estipulado en la actividad.
            */

            string[] arreglo_n = new string[5];
            string[] arreglo_a = new string[5];
            int[] arreglo_e = new int[5];
            char[] arreglo_s = new char[5];

            for(int i = 0; i<arreglo_n.Length; i++){
                Console.Write("Ingrese el nombre de la persona N° {0}: ", i+1);
                arreglo_n[i] = Console.ReadLine();
                Console.Write("Ingrese el apellido de la persona N° {0}: ", i+1);
                arreglo_a[i] = Console.ReadLine();
                Console.Write("Ingrese la edad de la persona N° {0}: ", i+1);
                arreglo_e[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el sexo de la persona N° {0} (M -> Para Masculino, F -> Para Femenino) ", i+1);
                arreglo_s[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            }

            for(int i = 0; i<arreglo_n.Length; i++){
                Console.WriteLine("Nombre -> {0}", arreglo_n[i]);
                Console.WriteLine("Apellido -> {0}", arreglo_a[i]);
                Console.WriteLine("Edad -> {0}", arreglo_e[i]);
                Console.WriteLine("Sexo -> {0}", arreglo_s[i]);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
