using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysSonMarket.Dto
{
    public class CategoriaDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome de categoria é obrigatório")]
        [StringLength(100, ErrorMessage ="Nome de Categoria muito grande, tente um nome menor!")]
        [MinLength(2, ErrorMessage = "Nome de Categoria muito pequeno, tente um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }
    }
}
