using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Barbeatia.API.Models
{
    public class Servico
    {

        [key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Favor colocar um nome para o serviço")]
        [DisplayName("Nome Serviço")]
        public string NomeServico { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Range(10, 999, ErrorMessage = "A duração precisa ser maior que 10 minutos")]
        public int DuracaoMin { get; set; }

        [Range(0.01, 999.00, ErrorMessage = "Preço deve ficar entre 0.01 e 100.00")]
        public double preco { get; set; }
    }
}