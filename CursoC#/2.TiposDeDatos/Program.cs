
using System;
namespace _2.TiposDeDatos
{
    class Program
    {
        public static void Main(string[] args){

            //tipos de datos

            //tipo de dato byte
            byte numeroByte = 10; //0-255
            //tipo de dato entero
            int numero = 10; // -2,147,483,648 to 2,147,483,647
            //tipo de dato decimal
            float numeroDecimal = 10.5f; // -3.402823e38 to 3.402823e38
            //tipo de dato double
            double numeroDouble = 10.5; // -1.79769313486232e308 to 1.79769313486232e308
            //tipo de dato booleano
            bool booleano = true; // true or false
            //tipo de dato string
            string cadena = "Hola Mundo"; //cadena de caracteres
            //tipo de dato char
            char caracter = 'a'; //caracter
            // tipo de dato dinamico
            dynamic datoDinamico = true; // 
            // tipo de dato var
            var datoVar = "algo";

            //imprimir en consola
            Console.WriteLine("Tipo de dato byte: " + numeroByte);
            Console.WriteLine("Tipo de dato numerico: " + numero);
            Console.WriteLine("Tipo de dato decimal: " + numeroDecimal);
            Console.WriteLine("Tipo de dato double: " + numeroDouble);
            Console.WriteLine("Tipo de dato booleano: " + booleano);
            Console.WriteLine("Tipo de dato string: " + cadena);
            Console.WriteLine("Tipo de dato char: " + caracter);
            Console.WriteLine("Tipo de dato dinamico: " + datoDinamico);
            Console.WriteLine("Tipo de dato var: " + datoVar);

            Console.ReadKey();
        }
    }
}


