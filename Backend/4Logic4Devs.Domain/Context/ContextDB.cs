using _4Logic4Devs.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace _4Logic4Devs.Context
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>()
               .HasOne(a => a.Cliente)
                  .WithMany(c => c.Avaliacoes)
                     .HasForeignKey(a => a.ClienteId);

        }
    }

}
