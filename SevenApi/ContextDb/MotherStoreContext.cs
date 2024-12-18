using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MotherStoreApi.Models;

namespace MotherStoreApi.ContextDb
{
    public class MotherStoreContext : DbContext
    {
        public MotherStoreContext(DbContextOptions<MotherStoreContext> options) : base(options) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Remove(typeof(ForeignKeyIndexConvention));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public DbSet<Article> Articles { get; set; } = null;
        public DbSet<Categorie> Categories { get; set; } = null;
    }
}
