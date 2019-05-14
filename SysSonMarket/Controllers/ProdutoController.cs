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

        [HttpPost]
        public IActionResult Atualizar(ProdutoDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var produto = database.Produtos.First(pro => pro.Id == dadosTemporario.Id);
                produto.Nome = dadosTemporario.Nome;
                produto.Categoria = database.Categorias.First(Categoria => Categoria.Id == dadosTemporario.CategoriaID);
                produto.Fornecedor = database.Fornecedores.First(Fornecedor => Fornecedor.Id == dadosTemporario.FornecedorID);
                produto.PrecoDeCusto = dadosTemporario.PrecoDeCusto;
                produto.PrecoDeVenda = dadosTemporario.PrecoDeVenda;
                produto.Medicao = dadosTemporario.Medicao;
                database.SaveChanges();
                return RedirectToAction("ListarProduto", "Gestao");
            }
            else
            {
                ViewBag.Categorias = database.Categorias.ToList();
                ViewBag.Fornecedor = database.Fornecedores.ToList();
                return View("../Gestao/EditarProduto"); 
            }
        }

        [HttpPost]
        public IActionResult Deletar(int Id)
        {
            if (Id > 0)
            {
                var produto = database.Produtos.First(pro => pro.Id == Id);
                produto.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("ListarProduto", "Gestao");
        }

        [HttpPost]
        public IActionResult RetornarProdutoTelaVenda(int Id)
        {
            if (Id > 0)
            {
                var produto = database.Produtos.Where(p => p.Status == true).Include(p => p.Categoria).Include(p => p.Fornecedor).First(pro => pro.Id == Id);
                if(produto != null)
                {
                    Response.StatusCode = 200; //ok
                    return Json(produto);
                }
                else
                {
                    Response.StatusCode = 404; //falha
                    return Json(null);
                }
            }
            else
            {
                Response.StatusCode = 404; //falha
                return Json(null);
            }


        }

    }
}