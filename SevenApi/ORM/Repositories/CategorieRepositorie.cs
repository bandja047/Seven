using Microsoft.EntityFrameworkCore;
using MotherStoreApi.ContextDb;
using MotherStoreApi.Helpers;
using MotherStoreBO.Models;
using MotherStoreApi.NewFolder;

namespace MotherStoreApi.ORM.Repositories
{
    public class CategorieRepositorie : GenericRepository<Categorie>
    {
        public CategorieRepositorie(MotherStoreContext context) : base(context)
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

        public override async Task<bool> UpdateAsync(Categorie entity)
        {
            var Item = await GetEntityAsNoTrackAsync(x=>x.Id==entity.Id);

            if (Item == null)
            {
                return false;
            }

            Item = Mapper.Map<Categorie, Categorie>(entity);
            
            Item.UpdatedAt = DateTime.Now;
            Item.DataVersion = entity.DataVersion + 1;
           

            return await base.UpdateAsync(Item);
        }

    }
   
}
