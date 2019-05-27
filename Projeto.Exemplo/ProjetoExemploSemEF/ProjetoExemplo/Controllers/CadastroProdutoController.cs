using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Generico.Dominio;
using Generico.Aplicacao;
using System.Net;

namespace ProjetoExemplo.Controllers
{
    public class CadastroProdutoController : Controller
    {
        // GET: CadastroProduto
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult ListarRegistro()
        {

            for (int i = 0; i < 10; i++)
            {
                //lista produto
                var tbuscar = new CadastroProdutoAplicacao();
                tbuscar.InseriProduto();
            }



            return View();
        }


    }
}