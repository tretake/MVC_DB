using projeto_mvc.Models;

namespace projeto_mvc.Data.Services
{
	public interface IPlataformaSevice
	{
		IEnumerable<Plataforma> GetAll();

		Plataforma GetById(int id);

		void Add(Plataforma plataforma);

		Plataforma Update(int id, Jogo plataforma);

		void Delete(int id);
	}
}
