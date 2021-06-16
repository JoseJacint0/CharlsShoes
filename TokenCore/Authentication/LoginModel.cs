﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokenCore.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Nombre de usuario requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Contraseña requerida")]
        public string Password { get; set; }
    }
}
