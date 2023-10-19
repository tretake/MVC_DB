using Microsoft.EntityFrameworkCore;
using projeto_mvc.Models;

namespace projeto_mvc.Data.Services
{
	public class PlataformaSevice : IPlataformaSevice
	{
		private readonly ProjetoContext _context;

		public PlataformaSevice(ProjetoContext context)
		{
			_context = context;
		}

		public void Add(Plataforma plataforma)
		{
			_context.Plataformas.Add(plataforma);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Plataforma> GetAll()
		{
			var resultado = _context.Plataformas.Include(n => n.jogos).ToList();

			return resultado;
		}

		public Plataforma GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Jogo Update(int id, Plataforma plataforma)
		{
			throw new NotImplementedException();
		}

		public Plataforma Update(int id, Jogo plataforma)
		{
			throw new NotImplementedException();
		}
	}
}
