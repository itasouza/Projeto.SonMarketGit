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
    public class CategoriaController : Controller
    {

        private readonly ApplicationDbContext database;

        public CategoriaController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CategoriaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                Categoria dados = new Categoria();
                dados.Nome = dadosTemporario.Nome;
                dados.Status = true;
                database.Categorias.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarCategoria", "Gestao");
            }
            else
            {
                return View("../Gestao/NovaCategoria");

               // return RedirectToAction("NovaCategoria", "Gestao", new { @id = 0 });
            }

        }

        [HttpPost]
        public IActionResult Atualizar(CategoriaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var categoria = database.Categorias.First(cat => cat.Id == dadosTemporario.Id);
                categoria.Nome = dadosTemporario.Nome;
                database.SaveChanges();
                return RedirectToAction("ListarCategoria", "Gestao");
            }
            else
            {
                return View("../Gestao/EditarCategoria");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int Id)
        {
            if (Id > 0)
            {
                var categoria = database.Categorias.First(cat => cat.Id == Id);
                categoria.Status = false;
                database.SaveChanges();
            }
              return RedirectToAction("ListarCategoria", "Gestao");
        }
      

    }
} 