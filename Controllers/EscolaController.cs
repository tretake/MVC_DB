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


        public IActionResult Editar(int id)
        {

            var aluno = _Context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();
            else
                return View(aluno);
        }

        [HttpPost]
        public IActionResult Editar(Aluno a)
        {
            var aluno = _Context.Alunos.Find(a.Id);

            if (aluno != null)
            {
                aluno.Nome = a.Nome;
                aluno.Serie = a.Serie;
                aluno.Idade = a.Idade;
                aluno.CPF = a.CPF;
                _Context.Update(aluno);
                _Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(a);

        }

        public IActionResult Detalhes(int id)
        {
            var aluno = _Context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        public IActionResult Deletar(int id)
        {
            var aluno = _Context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Deletar(Aluno a)
        {
            var aluno = _Context.Alunos.Find(a.Id);

            if (aluno == null)
                return NotFound();

            _Context.Alunos.Remove(aluno);
            _Context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

    }
}