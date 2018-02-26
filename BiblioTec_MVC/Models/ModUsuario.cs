using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiblioTec_MVC.Models
{
    public class ModUsuario
    {

        public string usuarioId { get; set; }

        [Display(Name = "Login: ")]
        [Required]
        public string login { get; set; }

        [Display(Name = "Senha: ")]
        [Required]
        public string senha { get; set; }

        [Display(Name = "E-Mail: ")]
        public string email { get; set; }
        [Display(Name = "Telefone: ")]
        public string telefone { get; set; }

    }
}