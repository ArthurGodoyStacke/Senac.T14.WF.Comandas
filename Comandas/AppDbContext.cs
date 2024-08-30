

using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    // classe que representa o banxo de dados
    public class AppDbContext : DbContext
    {
        //propriedade que representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }
        // métodos que configura informando para EF que o banco será SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }


}
