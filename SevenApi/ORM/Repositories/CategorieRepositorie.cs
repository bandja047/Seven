using Microsoft.EntityFrameworkCore;
using SevenApi.ContextDb;
using SevenApi.Models;
using SevenApi.NewFolder;

namespace SevenApi.ORM.Repositories
{
    public class CategorieRepositorie : GenericRepository<Categorie>
    {
        public CategorieRepositorie(SevenContext context) : base(context)
        {
        }

        public override async Task AddAsync(Categorie entity)
        {

            var latestCategorieId = await MaxAsync(c => (int?)c.Id);

            entity.Reference = $"{latestCategorieId}{ReferenceGenerator.GenerateTimeStampedReference()}";
          
            entity.UpdatedAt = DateTime.Now;
            entity.CreatedAt = DateTime.Now;

            await base.AddAsync(entity);
        }

    }
   
}
