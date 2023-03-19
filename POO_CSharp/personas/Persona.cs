using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personas
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public void Presentarse()
        {
            Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años.", Nombre, Edad);
        }

        public void Comer(string comida)
        {
            Console.WriteLine("{0} está comiendo {1}.", Nombre, comida);
        }

        public void Dormir()
        {
            Console.WriteLine("{0} está durmiendo.", Nombre);
        }
    }
}