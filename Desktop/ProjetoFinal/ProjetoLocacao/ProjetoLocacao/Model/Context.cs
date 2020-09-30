using Microsoft.EntityFrameworkCore;

namespace ProjetoLocacao.Model
{
    class Context : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Agente> agentes { get; set; }
        public DbSet<Veiculo> veiculos { get; set; }
        public DbSet<Locacao> locacoes { get; set; }
        public DbSet<Devolucao> devolucoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:locacao.database.windows.net,1433;
                                        Database=BancoLocacao;
                                        User ID=eliseu;
                                        Password=Positivo123;
                                        trusted_Connection=false");
        }
    }
}
