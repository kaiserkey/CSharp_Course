using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Escriba su nombre")]
        [MinLength(5, ErrorMessage = "El nombre debe tener al menos 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener máximo 10 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Escriba su apellido")]
        [MinLength(5, ErrorMessage = "El apellido debe tener al menos 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El apellido debe tener máximo 10 caracteres")]
        public string Apellido { get; set; }
        public string NickName { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}