using Microsoft.EntityFrameworkCore;
using Market.Objects;

namespace Market.DBConection
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options){}

        public DbSet<Product> Product{get; private set;}
        public DbSet<Client> Client{get; private set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurate the function "now()" on these colun's
            modelBuilder.Entity<Product>()
                .Property(p => p.Regis_Product)
                .HasDefaultValueSql("now()");

            modelBuilder.Entity<Client>()
                .Property(p => p.Regis_Client)
                .HasDefaultValueSql("now()");    
        }

    }
}