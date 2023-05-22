using System;
using Producto;//se llama al namespace de la clase Telefono
namespace _12.POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Telefono miTelefono = new Telefono();
            
            miTelefono.Marca = "Samsung";
            miTelefono.Color="Negro";
            miTelefono.setTipo("Smartphone");
            Telefono.tamanno = "Grande";

            miTelefono.Info();
            miTelefono.Llamar();
            miTelefono.Colgar();
            
        }
    }
}
