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
    public class FornecedorController : Controller
    {
        private readonly ApplicationDbContext database;

        public FornecedorController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(FornecedorDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                Fornecedor dados = new Fornecedor();
                dados.Nome = dadosTemporario.Nome;
                dados.Email = dadosTemporario.Email;
                dados.Telefone = dadosTemporario.Telefone;
                dados.Status = true;
                database.Fornecedores.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarFornecedor", "Gestao");
            }
            else
            {
                return View("../Gestao/NovoFornecedor");

               //  return RedirectToAction("NovoFornecedor", "Gestao");
            }


        }
    }
}