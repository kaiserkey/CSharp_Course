using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personas
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string dni;
        private string direccion;
        private string telefono;
        private string email;
        private string sexo;

        public Persona()
        {
            nombre = "";
            apellido = "";
            edad = 0;
            dni = "";
            direccion = "";
            telefono = "";
            email = "";
            sexo = "";
        }

        public Persona(string nombre, string apellido, int edad, string direccion, string telefono, string email, string sexo){
            this.nombre = nombre;
            this.apellido = apellido;
            
        }
    }
}