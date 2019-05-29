using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovoSonMarket.Dto
{
    public class FornecedorDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome de Fornecedor é obrigatório")]
        [StringLength(100, ErrorMessage = "Nome de Fornecedor muito grande, tente um nome menor!")]
        [MinLength(2, ErrorMessage = "Nome de Fornecedor muito pequeno, tente um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail do fornecedor é obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone do fornecedor é obrigatório")]
        [Phone(ErrorMessage ="Telefone inválido")]
        public string Telefone { get; set; }
    }
}
