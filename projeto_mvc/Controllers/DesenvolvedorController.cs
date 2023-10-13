using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Data;

namespace projeto_mvc.Controllers
{
    public class DesenvolvedorController : Controller
    {
        private readonly ProjetoContext _context;
        public DesenvolvedorController(ProjetoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dados = _context.Desenvolvedores.ToList();
            return View(dados);
        }
    }
}
