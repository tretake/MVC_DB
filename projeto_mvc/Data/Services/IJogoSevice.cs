using projeto_mvc.Models;

namespace projeto_mvc.Data.Services
{
    public interface IJogoSevice
    {
        IEnumerable<Jogo> GetAll();

        Jogo GetById(int id);

        void Add(Jogo jogo);

        Jogo Update(int id, Jogo jogo);

        void Delete(int id);

    }
}
