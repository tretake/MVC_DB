using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Data;

namespace projeto_mvc.Controllers
{
    public class PlataformaController : Controller
    {
        private readonly ProjetoContext _context;
        public PlataformaController(ProjetoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dados = _context.Plataformas.ToList();
            return View(dados);
        }
    }
}
