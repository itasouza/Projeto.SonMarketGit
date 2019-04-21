using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysSonMarket.Data;

namespace SysSonMarket.Controllers
{
    public class GestaoController : Controller
    {

        private readonly ApplicationDbContext database;

        public GestaoController(ApplicationDbContext database)
        {
            this.database = database;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarCategoria()
        {
            return View();
        }

        public IActionResult NovaCategoria()
        {
            return View();
        }

        public IActionResult ListarFornecedor()
        {
            return View();
        }

        public IActionResult NovoFornecedor()
        {
            return View();
        }


        public IActionResult ListarProduto()
        {

            return View();
        }

        public IActionResult NovoProduto()
        {
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Fornecedor = database.Fornecedores.ToList();

            return View();
        }


    }
}