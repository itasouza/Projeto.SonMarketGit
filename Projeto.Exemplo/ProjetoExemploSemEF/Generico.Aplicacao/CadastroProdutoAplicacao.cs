using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generico.Dominio;
using Generico.Repositorio;
using System.Data.SqlClient;
using System.Globalization;

namespace Generico.Aplicacao
{
   public class CadastroProdutoAplicacao
    {
        private ContextoRemoto ContextoRemoto;
        private Contexto contexto;


        public void InseriProduto()
        {

            var strQueryProduto = "select  descricaoproduto, precoreposicao, precovenda from tb_produto";


            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQueryProduto);


                while (retornoDataReader.Read())
                {

                    var strQuery1 = "";
                    strQuery1 += " INSERT INTO Produtos (NOME,CategoriaId,FornecedorId,PrecoDeCusto,PrecoDeVenda,Medicao,Status)";
                    strQuery1 += string.Format(" VALUES (");
                    strQuery1 += string.Format(" '{0}', ", retornoDataReader["descricaoproduto"] == DBNull.Value ? string.Empty : retornoDataReader["descricaoproduto"].ToString());
                    strQuery1 += string.Format(" {0}, ", 1);
                    strQuery1 += string.Format(" {0},  ", 6);
                    strQuery1 += string.Format(CultureInfo.InvariantCulture, " {0:0.00} , ", retornoDataReader["precoreposicao"] == DBNull.Value ? 0 : Convert.ToDecimal(retornoDataReader["precoreposicao"]));
                    strQuery1 += string.Format(CultureInfo.InvariantCulture, " {0:0.00} , ", retornoDataReader["precovenda"] == DBNull.Value ? 0 : Convert.ToDecimal(retornoDataReader["precovenda"]));
                    strQuery1 += string.Format(" {0},  ", 2);
                    strQuery1 += string.Format(" {0}  ", 1);
                    strQuery1 += string.Format(" ) ");

                    using (ContextoRemoto = new ContextoRemoto())
                    {
                        ContextoRemoto.ExecutaComando(strQuery1);
                    }

                }
                retornoDataReader.Close();
            }

        }


    }
}
