using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generico.Dominio;
using Generico.Repositorio;
using System.Data.SqlClient;

namespace Generico.Aplicacao
{
   public class ListagemProdutoAplicacao
    {
        private Contexto contexto;
        private ContextoRemoto ContextoRemoto;


        public List<TB_PRODUTO> ListarTodos()
        {
            var strQuery = "select  descricaoproduto, precoreposicao, precovenda from tb_produto";

            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader);
            }

        }

       





        private List<TB_PRODUTO> TransformaReaderEmListaObjetos(SqlDataReader reader)
        {
            var retornando = new List<TB_PRODUTO>();
            while (reader.Read())
            {

                TB_PRODUTO tabela = new TB_PRODUTO()
                {
                 
                    descricao = reader["descricaoproduto"] == DBNull.Value ? string.Empty : reader["descricaoproduto"].ToString(),
                    precoreposicao = reader["precoreposicao"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["precoreposicao"]),
                    precovenda = reader["precovenda"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["precovenda"]),
               };

                retornando.Add(tabela);
            }
            reader.Close();
            return retornando;
        }


    }
}
