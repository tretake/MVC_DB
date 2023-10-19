using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Data;
using projeto_mvc.Data.Services;
using projeto_mvc.Models;

namespace projeto_mvc.Controllers
{
    public class PlataformaController : Controller
    {

		private readonly IPlataformaSevice _service;


		public PlataformaController(IPlataformaSevice service)
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
		public IActionResult Create([Bind("LogoImg,Nome,DataLancamento,Desenvolvedor")] Plataforma Pplataforma)
		 {
			if (!ModelState.IsValid)
			{
				return View(Pplataforma);
			}
			_service.Add(Pplataforma);
			return RedirectToAction(nameof(Index));
		}

	}
}
