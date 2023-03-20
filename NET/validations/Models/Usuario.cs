using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validations.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NickName { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }


    }
}