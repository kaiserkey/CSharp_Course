using System;
namespace _5.EstructuraSwitch
{
    class Program
    {
        public static void Main(string[] args)
        {
            //estructura switch-case
            Console.Write("Ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Entro al caso 1");
                    break;
                case 2:
                    Console.WriteLine("Entro al caso 2");
                    break;
                case 3:
                    Console.WriteLine("Entro al caso 3");
                    break;
                default:
                    Console.WriteLine("Entro al caso por defecto!");
                    break;
            }
            
        }
    }
}
