using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producto
{
    public class Telefono
    {
        private string marca;
        private string color;
        private string tipo;
        public static string tamanno; // los atributos estaticos pueden llamarce sin ser inicializados 
        public Telefono(){}
        public Telefono(string marca, string color, string tipo)
        {
            this.marca = marca;
            this.color = color;
            this.tipo = tipo;
        }

        public void Llamar()
        {
            Console.WriteLine("Llamando...");
        }

        public void Colgar()
        {
            Console.WriteLine("Colgando...");
        }

        public void Info()
        {
            Console.WriteLine("marca: " + marca);
            Console.WriteLine("color: " + color);
            Console.WriteLine("tipo: " + tipo);
            Console.WriteLine("Tamaño: " + tamanno);
        }

        //primer metodo para get y set
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        //segundo metodo para get y set
        public string Color{
            get { return color; }
            set { color = value; }
        }

        //el metodo clasico para los get y set
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipo()
        {
            return tipo;
        }

    }
}