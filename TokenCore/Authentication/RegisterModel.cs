using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokenCore.Authentication
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "Nombre de usuario requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Correo requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        public string Password { get; set; }
    }
}
