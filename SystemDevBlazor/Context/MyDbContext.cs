using Microsoft.EntityFrameworkCore;
using SystemDevBlazor.Data;

namespace SystemDevBlazor.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Atividade> Atividades { get; set;  }

    }
}
