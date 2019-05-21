using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        #region Categoria
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
        #endregion


        #region Fornecedor

        public IActionResult ListarFornecedor()
        {
            var fornecedor = database.Fornecedores.Where(forne => forne.Status == true).ToList();
            return View(fornecedor);
        }

        public IActionResult NovoFornecedor()
        {
            return View();
        }

        public IActionResult EditarFornecedor(int id)
        {
            var fornecedor = database.Fornecedores.First(forne => forne.Id == id);
            FornecedorDto fornecedorView = new FornecedorDto();
            fornecedorView.Id = fornecedor.Id;
            fornecedorView.Nome = fornecedor.Nome;
            fornecedorView.Email = fornecedor.Email;
            fornecedorView.Telefone = fornecedor.Telefone;
            return View(fornecedorView);
        }

        #endregion


        #region Produto
        public IActionResult ListarProduto()
        {
            var produto = database.Produtos.Include(p => p.Categoria).Include(p => p.Fornecedor).Where(p => p.Status == true).ToList();
            return View(produto);
        }

        public IActionResult NovoProduto()
        {
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Fornecedor = database.Fornecedores.ToList();

            return View();
        }

        public IActionResult EditarProduto(int id)
        {
            var produto = database.Produtos.Include(p => p.Categoria).Include(p => p.Fornecedor).First(pro => pro.Id == id);
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Fornecedor = database.Fornecedores.ToList();

            ProdutoDto produtoView = new ProdutoDto();
            produtoView.Id = produto.Id;
            produtoView.Nome = produto.Nome;
            produtoView.PrecoDeCustoString = Convert.ToString(produto.PrecoDeCusto);
            produtoView.PrecoDeVendaString = Convert.ToString(produto.PrecoDeVenda);
            produtoView.Medicao = produto.Medicao;
            produtoView.CategoriaID = produto.Categoria.Id;
            produtoView.FornecedorID = produto.Fornecedor.Id;

            return View(produtoView);
        }
        #endregion


        #region promoção
        public IActionResult ListarPromocao()
        {
            var promocao = database.Promocoes.Include(p => p.Produto).Where(p => p.Status == true).ToList();
            return View(promocao);
        }

        public IActionResult NovoPromocao()
        {
            ViewBag.Produto = database.Produtos.ToList();
            return View();
        }

        public IActionResult EditarPromocao(int id)
        {
            var promocao = database.Promocoes.Include(p => p.Produto).First(pro => pro.Id == id);
            ViewBag.Produto = database.Produtos.ToList();

            PromocaoDTO promocaoView = new PromocaoDTO();
            promocaoView.Id = promocao.Id;
            promocaoView.Nome = promocao.Nome;
            promocaoView.ProdutoID = promocao.Produto.Id;
            promocaoView.Porcentagem = promocao.Porcentagem;
            return View(promocaoView);
        }

        #endregion

        #region Estoque

        public IActionResult ListarEstoque()
        {
            var estoque = database.Estoques.Include(p => p.Produto).Where(q => q.Status == true).ToList();
            return View(estoque);
        }

        public IActionResult NovoEstoque()
        {
            ViewBag.Produto = database.Produtos.ToList();
            return View();
        }

        public IActionResult EditarEstoque(int id)
        {
            var estoque = database.Estoques.Include(p => p.Produto).First(e => e.Id == id);
            ViewBag.Produto = database.Produtos.ToList();

            EstoqueDto estoqueView = new EstoqueDto();
            estoqueView.Id = estoque.Id;
            estoqueView.ProdutoID = estoque.Produto.Id;
            estoqueView.Quantidade = estoque.Quantidade;
            return View(estoqueView);
        }

        #endregion

    }
}