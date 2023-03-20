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

        [Required(ErrorMessage = "Escriba su nickname")]
        [MinLength(5, ErrorMessage = "El nickname debe tener al menos 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El nickname debe tener máximo 10 caracteres")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "Escriba su edad")]
        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100 años")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La edad debe ser un número")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Escriba su correo")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [MinLength(5, ErrorMessage = "El correo debe tener al menos 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El correo debe tener máximo 10 caracteres")]
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}