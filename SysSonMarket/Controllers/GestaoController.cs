using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysSonMarket.Data;
using SysSonMarket.Dto;

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
            var categorias = database.Categorias.Where(cat => cat.Status == true).ToList();
            return View(categorias);
        }

        public IActionResult NovaCategoria()
        {
            return View();
        }

        public IActionResult EditarCategoria(int id)
        {
            var categoria = database.Categorias.First(cat => cat.Id == id);
            CategoriaDto categoriaView = new CategoriaDto();
            categoriaView.Id = categoria.Id;
            categoriaView.Nome = categoria.Nome;
            return View(categoriaView);
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