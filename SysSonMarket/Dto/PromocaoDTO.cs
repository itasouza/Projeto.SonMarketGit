using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysSonMarket.Dto
{
    public class PromocaoDTO
    {
        [Required]
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome da Promoção e obrigatório")]
        [StringLength(100,ErrorMessage ="O nome da promoção deve ter no máxmo 100 caracteres")]
        [MinLength(3,ErrorMessage ="O nome da promoção deve ter no mínimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Produto do produto e obrigatório")]
        public int ProdutoID { get; set; }

        [Required]
        [Range(0,100)]
        public float Porcentagem { get; set; }

    }
}
