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
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext database;

        public ProdutoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                Produto dados = new Produto();
                dados.Nome = dadosTemporario.Nome;
                dados.Categoria = database.Categorias.First(Categoria => Categoria.Id == dadosTemporario.CategoriaID);
                dados.Fornecedor = database.Fornecedores.First(Fornecedor => Fornecedor.Id == dadosTemporario.FornecedorID);
                dados.PrecoDeCusto = dadosTemporario.PrecoDeCusto;
                dados.PrecoDeVenda = dadosTemporario.PrecoDeVenda;
                dados.Medicao = dadosTemporario.Medicao;
                dados.Status = true;
                database.Produtos.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarProduto", "Gestao");
            }
            else
            {
                ViewBag.Categorias = database.Categorias.ToList();
                ViewBag.Fornecedor = database.Fornecedores.ToList();
                return View("../Gestao/NovoProduto");

                //  return RedirectToAction("NovoFornecedor", "Gestao");
            }


        }
    }
}