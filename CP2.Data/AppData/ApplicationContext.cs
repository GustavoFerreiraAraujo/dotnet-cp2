using CP2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CP2.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<FornecedorEntity> Fornecedor { get; set; }
        public DbSet<VendedorEntity> Vendedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendedorEntity>(entity =>
            {
                entity.Property(v => v.ComissaoPercentual)
                    .HasColumnType("decimal(18,2)"); 

                entity.Property(v => v.MetaMensal)
                    .HasColumnType("decimal(18,2)"); 
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
