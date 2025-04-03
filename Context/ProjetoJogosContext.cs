using Microsoft.EntityFrameworkCore;
using ProjetoJogos.Domains;

namespace ProjetoJogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
        //Metodo construtor tem o mesmo nome da classe 
        public ProjetoJogosContext() { }

        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options) : base(options)
        {

        }
        public DbSet<Jogos> Jogos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ROQUE; Database=filmes_senai; Integrated Security=True; TrustServerCertificate=true;");
            }
        }
    }
}
