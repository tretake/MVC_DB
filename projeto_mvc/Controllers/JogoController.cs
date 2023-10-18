using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_mvc.Data;

namespace projeto_mvc.Controllers
{
    public class JogoController : Controller
    {
        private readonly ProjetoContext _context;
        public JogoController(ProjetoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dados = _context.Jogos.Include(n => n.desenvolvedor).Include(n => n.plataformas).ToList();
            return View(dados);
        }
    }
}
