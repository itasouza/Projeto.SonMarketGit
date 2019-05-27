using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Dominio
{
   public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Categoria { get; set; }
        public int Fornecedor { get; set; }
        public float PrecoDeCusto { get; set; }
        public float PrecoDeVenda { get; set; }
        public int Medicao { get; set; }
        public bool Status { get; set; }
    }
}
