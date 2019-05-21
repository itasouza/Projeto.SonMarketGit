using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysSonMarket.Data;
using SysSonMarket.Dto;
using SysSonMarket.Models;

namespace SysSonMarket.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly ApplicationDbContext database;

        public EstoqueController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(EstoqueDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                Estoque dados = new Estoque();

                dados.Produto = database.Produtos.First(Produto => Produto.Id == dadosTemporario.ProdutoID);
                dados.Quantidade = dadosTemporario.Quantidade;
                dados.Status = true;
                database.Estoques.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarEstoque", "Gestao");
            }
            else
            {
                ViewBag.Produto = database.Produtos.ToList();
                return View("../Gestao/NovoEstoque");
            }
        }


        [HttpPost]
        public IActionResult Atualizar(EstoqueDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var dados = database.Estoques.First(est => est.Id == dadosTemporario.Id);
                dados.Produto = database.Produtos.First(pro => pro.Id == dadosTemporario.ProdutoID);
                dados.Quantidade = dadosTemporario.Quantidade;
                database.SaveChanges();
                return RedirectToAction("ListarEstoque", "Gestao");
            }
            else
            {
                ViewBag.Produto = database.Produtos.ToList();
                return View("../Gestao/EditarEstoque");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int Id)
        {
            if (Id > 0)
            {
                var dados = database.Estoques.First(est => est.Id == Id);
                dados.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("ListarEstoque", "Gestao");
        }

    }
}