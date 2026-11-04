using Microsoft.EntityFrameworkCore;
using Market.Objects;
using Market.Relations;

namespace Market.DBConection
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options){}

        public DbSet<Product> Product{get; private set;}
        public DbSet<Client> Client{get; private set;}
        public DbSet<Client> Employee{get; private set;}
        public DbSet<Client> Supplier{get; private set;}
        public DbSet<Client> CashRegis{get; private set;}
        public DbSet<Invoice> Invoice { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurate the function "now()" on these colun's
            
            // ENTITYS
            
            modelBuilder.Entity<Product>()
                .Property(p => p.Regis_Product)
                .HasDefaultValueSql("now()");

            modelBuilder.Entity<Client>()
                .Property(p => p.Regis_Client)
                .HasDefaultValueSql("now()");

            modelBuilder.Entity<Employee>()
                .Property(p => p.Regis_Employee)
                .HasDefaultValueSql("now()");

            modelBuilder.Entity<Supplier>()
                .Property(p => p.Regis_Supplier)
                .HasDefaultValueSql("now()");   

            modelBuilder.Entity<CashRegister>()
                .Property(p => p.Last_Update)
                .HasDefaultValueSql("now()");

            // RELATIONS

            modelBuilder.Entity<Invoice>()
                .Property(p => p.Invoice_Date)
                .HasDefaultValueSql("now()");
            modelBuilder.Entity<Invoice>()
                .HasOne(p => p.Supplier)
                .WithMany()
                .HasForeignKey(p => p.Fk_Id_Supplier)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Invoice>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.Fk_Id_Product)
                .OnDelete(DeleteBehavior.Restrict);
            
        }

    }
}