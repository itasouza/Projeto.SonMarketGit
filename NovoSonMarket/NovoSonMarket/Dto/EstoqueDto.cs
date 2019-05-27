using SysSonMarket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysSonMarket.Dto
{
    public class EstoqueDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do Produto é Obrigatório")]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Quantidade do estoque é Obrigatório")]
        public float Quantidade { get; set; }

        

    }
}
