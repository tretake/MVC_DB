using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_mvc.Data;
using projeto_mvc.Data.Services;
using projeto_mvc.Models;

namespace projeto_mvc.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogoSevice _service;
        public JogoController(IJogoSevice service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var dados = _service.GetAll();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("CapaImg,Nome,DataLancamento,Id_Dev,Id_Plataforma")] Jogo Pjogo)
		{
            if(!ModelState.IsValid)
            {
				return View(Pjogo);
			}
            _service.Add(Pjogo);
            return RedirectToAction(nameof(Index));
		}
	}
}
