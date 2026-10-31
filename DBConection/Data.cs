using Microsoft.EntityFrameworkCore;
using Market.Objects;

namespace Market.DBConection
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options){}

        public DbSet<Product> Product{get;set;}
    }
}