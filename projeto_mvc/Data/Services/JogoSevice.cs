using Microsoft.EntityFrameworkCore;
using projeto_mvc.Models;

namespace projeto_mvc.Data.Services
{
    public class JogoSevice : IJogoSevice
    {

        private readonly ProjetoContext _context;

        public JogoSevice(ProjetoContext context)
        {
            _context = context;
        }

        public void Add(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogo> GetAll()
        {
            var resultado = _context.Jogos.Include(n => n.desenvolvedor).Include(n => n.plataforma).ToList();

            return resultado;
        }

        public Jogo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Jogo Update(int id, Jogo jogo)
        {
            throw new NotImplementedException();
        }
    }
}
