﻿using System.ComponentModel.DataAnnotations;

namespace NSE.Identidade.API.Models
{
    public class UsuarioLogin
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} esta em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = " O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
