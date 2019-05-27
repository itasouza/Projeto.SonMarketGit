using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Generico.Dominio;
using Generico.Aplicacao;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace ProjetoExemplo.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        // GET: CadastroUsuario
        public ActionResult Index()
        {
             return View();

        }



        [HttpPost]
        public ActionResult Index(TB_USUARIO dadosTabela)
        {

            try
            {

                var tTabela = new CadastroUsuarioAplicacao();
                tTabela.Inseri(dadosTabela.NOME,
                            dadosTabela.LOGIN,
                            dadosTabela.SENHA,
                            dadosTabela.ADMINISTRADOR);
                TempData["msg"] = "Registro cadastrado com sucesso";
                return RedirectToAction("Index", "CadastroUsuario");
            }
            catch (Exception)
            {
                TempData["Erro"] = "Não foi possivel gravar o registro.";
                return RedirectToAction("Index", "CadastroUsuario");
            }

        }


        public ActionResult ListarRegistro()
        {

            //lista 
            var tbuscar = new CadastroUsuarioAplicacao();
            var listar = tbuscar.ListarTodos();
            return View(listar);
        }


        public ActionResult ExcluirRegistro(int id)
        {
            try
            {

                var tbuscar = new CadastroUsuarioAplicacao();
                tbuscar.Excluir(id);
                TempData["msg"] = "Registro Excluido Com Sucesso";
                return RedirectToAction("ListarRegistro", "CadastroUsuario");

            }
            catch (Exception)
            {
                TempData["Erro"] = "Erro ao Excluir Registro..";
                return RedirectToAction("ListarRegistro", "CadastroUsuario");
            }

        }

        public ActionResult AlteraRegistro(int id)
        {

            try
            {
                var tbuscar = new CadastroUsuarioAplicacao();
                TB_USUARIO tbUsuario = tbuscar.ListarPorID(id);
                return View(tbUsuario);
            }
            catch (Exception)
            {
                TempData["Erro"] = "Erro ao Alterar Registro.";
                return RedirectToAction("ListarRegistro", "CadastroUsuario");
            }

        }


        public ActionResult AlteraRegistroUpdate(TB_USUARIO dadosTabela)
        {
            try
            {

                var tTabela = new CadastroUsuarioAplicacao();
                tTabela.AlterarRegistro(dadosTabela.IDUSUARIO,
                                        dadosTabela.NOME,
                                        dadosTabela.LOGIN,
                                        dadosTabela.SENHA,
                                        dadosTabela.ADMINISTRADOR);
                TempData["msg"] = "Registro alterado com sucesso";
                return RedirectToAction("Index", "CadastroUsuario");

            }
            catch (Exception)
            {
                TempData["Erro"] = "Erro ao alterar Registro..";
                return RedirectToAction("ListarRegistro", "CadastroUsuario");
            }


        }


    }



}
