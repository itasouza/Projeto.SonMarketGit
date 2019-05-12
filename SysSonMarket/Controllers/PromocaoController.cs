using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SysSonMarket.Data;
using SysSonMarket.Dto;
using SysSonMarket.Models;

namespace SysSonMarket.Controllers
{
    public class PromocaoController : Controller
    {
        private readonly ApplicationDbContext database;

        public PromocaoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(PromocaoDTO dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                Promocao dados = new Promocao();
                dados.Nome = dadosTemporario.Nome;
                dados.Produto = database.Produtos.First(Produto => Produto.Id == dadosTemporario.ProdutoID);
                dados.Porcentagem = dadosTemporario.Porcentagem;
                dados.Status = true;
                database.Promocoes.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarPromocao", "Gestao");
            }
            else
            {
                ViewBag.Produto = database.Produtos.ToList();
                return View("../Gestao/NovoPromocao");

                //  return RedirectToAction("NovoFornecedor", "Gestao");
            }
        }


        [HttpPost]
        public IActionResult Atualizar(PromocaoDTO dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var dados = database.Promocoes.First(pro => pro.Id == dadosTemporario.Id);

                dados.Nome = dadosTemporario.Nome;
                dados.Produto = database.Produtos.First(produto => produto.Id == dadosTemporario.ProdutoID);
                dados.Porcentagem = dadosTemporario.Porcentagem;
                database.SaveChanges();
                return RedirectToAction("ListarPromocao", "Gestao");
            }
            else
            {
                ViewBag.Categorias = database.Categorias.ToList();
                ViewBag.Fornecedor = database.Fornecedores.ToList();
                return View("../Gestao/EditarPromocao");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int Id)
        {
            if (Id > 0)
            {
                var dados = database.Promocoes.First(pro => pro.Id == Id);
                dados.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("ListarPromocao", "Gestao");
        }


    }
}