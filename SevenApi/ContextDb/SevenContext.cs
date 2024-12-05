using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Seven.Models;

namespace Seven.ContextDb
{
    public class SevenContext : DbContext
    {
        public SevenContext(DbContextOptions<SevenContext> options) : base(options) { }

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
