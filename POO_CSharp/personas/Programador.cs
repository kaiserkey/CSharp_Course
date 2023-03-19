using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personas
{
    public class Programador : Persona
    {
        private string Lenguaje { get; set; }

        public Programador(string nombre, int edad, string genero, string lenguaje) : base(nombre, edad, genero)
        {
            Lenguaje = lenguaje;
        }

        public void Programar()
        {
            Console.WriteLine("{0} está programando en {1}.", Nombre.GetEnumerator(), Lenguaje);
        }
    }
}