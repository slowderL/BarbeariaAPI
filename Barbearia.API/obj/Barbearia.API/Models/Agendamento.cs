using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbeatia.API.Models
{
    public class Agendamento
    {
        [key]
        public int AgendamentoID { get; set; }

        [Required]
        public int ClieneID { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        public string Observacoes { get; set; }

        [Required]
        public int Status { get; set; }
    }
}