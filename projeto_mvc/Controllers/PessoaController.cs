using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Data;

namespace projeto_mvc.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ProjetoContext _context;
        public PessoaController(ProjetoContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dados = _context.Pessoas.ToList();
            return View(dados);
        }
    }
}
