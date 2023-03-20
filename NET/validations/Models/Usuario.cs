using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System

namespace validations.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Escriba su nombre")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NickName { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}