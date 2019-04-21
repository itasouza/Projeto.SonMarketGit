using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysSonMarket.Dto
{
    public class ProdutoDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome do Produto é Obrigatório")]
        [StringLength(100,ErrorMessage ="Nome do produto tem que ter menos de 100 caracteres")]
        [MinLength(2, ErrorMessage = "Nome do produto tem que ter mais de 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Categoria do produto e obrigatório")]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Fornecedor do produto e obrigatório")]
        public int FornecedorID { get; set; }

        [Required(ErrorMessage ="Preço de custo do produto e obrigatório")]
        public float PrecoDeCusto { get; set; }

        [Required(ErrorMessage = "Preço de venda do produto e obrigatório")]
        public float PrecoDeVenda { get; set; }

        [Required(ErrorMessage = "Medição do produto e obrigatório")]
        [Range(0,2,ErrorMessage ="Medição inválida")]
        public int Medicao { get; set; }

    }
}
