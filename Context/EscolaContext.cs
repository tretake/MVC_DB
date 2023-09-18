using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDB.Models;

namespace MvcDB.Context
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> option) : base(option)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}