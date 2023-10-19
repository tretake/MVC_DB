using Microsoft.EntityFrameworkCore;
using projeto_mvc.Models;

namespace projeto_mvc.Data
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        

    }
}
