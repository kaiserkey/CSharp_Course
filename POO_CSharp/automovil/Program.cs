using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automovil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.Marca = "Megane";
            auto1.Modelo = "Sport";
            Console.WriteLine("Marca: " + auto1.Marca);
            Console.WriteLine("Modelo: " + auto1.Modelo);
            Console.WriteLine()
        }
    }
}




