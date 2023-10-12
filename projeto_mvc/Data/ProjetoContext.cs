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

            

            modelBuilder.Entity<Plataforma_Jogo>().HasKey( pj => new
            {
                pj.IdJogo,
                pj.IdPlataforma
            });

            /*
            modelBuilder.Entity<Plataforma_Jogo>().HasOne(j => j.jogo).WithMany(pj => pj.plataforma_jogos)
                .HasForeignKey(j => j.IdJogo).OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Plataforma_Jogo>().HasOne(p => p.plataforma).WithMany(pj => pj.plataforma_jogos)
                .HasForeignKey(p => p.IdPlataforma).OnDelete(DeleteBehavior.Restrict); 
            */
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Plataforma_Jogo> PlataformaJogos { get; set; }

    }
}
