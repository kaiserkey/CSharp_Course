using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validations.Models
{
    public class Usuario
    {
        [RequiredAttributered(ErrorMessage = "Escriba su nombre")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NickName { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}