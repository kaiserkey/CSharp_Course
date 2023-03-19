using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automovil
{
    public class Auto
    {
        //atributos
        private string marca;
        private string modelo;
        private string color;
        private string tipo_combustible;
        private float velcidad;
        private int anio;
        private int kilometraje;
        private int precio;
        private int numero_ruedas;
        private int numero_puertas;
        private int numero_asientos;
        private int numero_cilindros;

        //constructor
        public Auto()
        {
            marca = "Ford";
            modelo = "Fiesta";
            color = "Rojo";
            tipo_combustible = "Gasolina";
            velcidad = 0;
            anio = 2019;
            kilometraje = 0;
            precio = 0;
            numero_ruedas = 4;
            numero_puertas = 4;
            numero_asientos = 5;
            numero_cilindros = 4;
        }

        //get y set
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        //metodos
        public void Acelerar()
        {
            velcidad += 10;
        }

        public void Frenar()
        {
            velcidad -= 10;
        }

        public void Encender()
        {
            Console.WriteLine("El auto se ha encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("El auto se ha apagado");
        }


    }
}