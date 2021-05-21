using Rotina.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Rotina.Infra.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext()
            : base("name=ClienteContext")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Cliente>().ToTable("Cliente");// classe que localiza o banco;
            base.OnModelCreating(modelBuilder);
        }
    }
}
