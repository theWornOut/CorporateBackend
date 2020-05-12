using System.Data.Entity;
using CorporateBackend.Dal.Concrete.EntityFramework.Mappings;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.EntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext()
        {
            Database.SetInitializer<EfDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

        public DbSet<Product> Products { get; set; }
    }
}