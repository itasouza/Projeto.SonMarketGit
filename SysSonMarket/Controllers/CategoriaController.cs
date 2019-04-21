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


    }
}