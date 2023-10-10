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
            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
