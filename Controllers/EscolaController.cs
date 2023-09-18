using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcDB.Context;
using MvcDB.Models;

namespace MvcDB.Controllers
{

    public class EscolaController : Controller
    {
        private readonly EscolaContext _Context;

        public EscolaController(EscolaContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            var Alunos = _Context.Alunos.ToList();
            return View(Alunos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Aluno a)
        {
            if (ModelState.IsValid)
            {
                _Context.Alunos.Add(a);
                _Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(a);
        }

        public IActionResult Deletar()
        {

            return RedirectToAction(nameof(Index));
        }

    }
}