using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoSonMarket.Data;
using NovoSonMarket.Dto;
using NovoSonMarket.Models;

namespace NovoSonMarket.Controllers
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
                dados.PrecoDeCusto = float.Parse(dadosTemporario.PrecoDeCustoString, CultureInfo.InvariantCulture.NumberFormat);
                dados.PrecoDeVenda = float.Parse(dadosTemporario.PrecoDeVendaString, CultureInfo.InvariantCulture.NumberFormat);
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
                produto.PrecoDeCusto = float.Parse(dadosTemporario.PrecoDeCustoString, CultureInfo.InvariantCulture.NumberFormat);
                produto.PrecoDeVenda = float.Parse(dadosTemporario.PrecoDeVendaString, CultureInfo.InvariantCulture.NumberFormat);
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
                if (produto != null)
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