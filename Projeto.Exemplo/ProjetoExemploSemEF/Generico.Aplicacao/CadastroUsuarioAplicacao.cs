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
   public class CadastroUsuarioAplicacao
    {
        private Contexto contexto;





        public List<TB_USUARIO> ListarTodos()
        {
            var strQuery = "select * from tb_usuario";

            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader);
            }

        }


        public TB_USUARIO ListarPorLoginSenha(string login, string senha)
        {
            var strQuery = string.Format("select * from tb_usuario where login = '{0}' and senha = '{1}' ", login, senha);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader).FirstOrDefault();
            }

        }

        public TB_USUARIO ListarPorLogin(string login)
        {
            var strQuery = string.Format("select * from tb_usuario where login = '{0}' ", login);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader).FirstOrDefault();
            }

        }


        public TB_USUARIO ListarPorID(int id)
        {
            var strQuery = string.Format("select * from tb_usuario where IDUSUARIO = '{0}' ", id);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaObjetos(retornoDataReader).FirstOrDefault();
            }

        }


        public void Inseri(string NOME, string LOGIN, string SENHA, bool ADMINISTRADOR)
        {

            string opcao = "";

            if (ADMINISTRADOR == true)
            {
                opcao = "S";
            }
            else
            {
                opcao = "N";
            }

            var strQuery = "";
            strQuery += " INSERT INTO TB_USUARIO (NOME,LOGIN,SENHA,ADMINISTRADOR)";

            strQuery += string.Format(" VALUES (");
            strQuery += string.Format(" '{0}', ", NOME);
            strQuery += string.Format(" '{0}', ", LOGIN);
            strQuery += string.Format(" '{0}',  ", SENHA);
            strQuery += string.Format(" '{0}'  ", opcao);
            strQuery += string.Format(" ) ");

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void AlterarRegistro(int IDUSUARIO, string NOME, string LOGIN, string SENHA, bool ADMINISTRADOR)
        {

            string opcao = "";

            if (ADMINISTRADOR == true)
            {
                opcao = "S";
            }
            else
            {
                opcao = "N";
            }

            var strQuery = "";
            strQuery += " UPDATE TB_USUARIO SET ";
            strQuery += string.Format(" NOME = '{0}', ", NOME);
            strQuery += string.Format(" LOGIN = '{0}', ", LOGIN);
            strQuery += string.Format(" SENHA = '{0}',  ", SENHA);
            strQuery += string.Format(" ADMINISTRADOR = '{0}'  ", opcao);
            strQuery += string.Format(" WHERE  IDUSUARIO = '{0}'  ", IDUSUARIO);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }


        private List<TB_USUARIO> TransformaReaderEmListaObjetos(SqlDataReader reader)
        {
            var retornando = new List<TB_USUARIO>();
            while (reader.Read())
            {

                TB_USUARIO tabela = new TB_USUARIO()
                {
                    IDUSUARIO = reader["IDUSUARIO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IDUSUARIO"]),
                    NOME = reader["NOME"] == DBNull.Value ? string.Empty : reader["NOME"].ToString(),
                    LOGIN = reader["LOGIN"] == DBNull.Value ? string.Empty : reader["LOGIN"].ToString(),
                    SENHA = reader["SENHA"] == DBNull.Value ? string.Empty : reader["SENHA"].ToString(),
                    ADMINISTRADOR = (reader["ADMINISTRADOR"] as string == "S") ? true : false
                };

                retornando.Add(tabela);
            }
            reader.Close();
            return retornando;
        }


        public void Excluir(int id)
        {
            var strQuery = string.Format("DELETE FROM  TB_USUARIO where IDUSUARIO = {0}", id);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }


    }
}
