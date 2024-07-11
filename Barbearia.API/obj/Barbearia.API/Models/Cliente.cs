using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbearia.API.Models
{
    public class Cliente
    {
        [Key]
        public int ClieneID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }

        [EmailAdress(ErrorMessage="Favor digitar um email valido")]
        public string Email { get; set; }

        [Required]
        [Display(Name="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}