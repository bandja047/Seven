using MotherStoreApi.ContextDb;
using MotherStoreBO.Models;
using MotherStoreApi.NewFolder;

namespace MotherStoreApi.ORM.Repositories
{
    public class FournisseurRepositorie : GenericRepository<Fournisseur>
    {
        public FournisseurRepositorie(MotherStoreContext context) : base(context)
        {

        }

        public override async Task AddAsync(Fournisseur entity)
        {

            var latestId = await MaxAsync(c => (int?)c.Id);

            entity.Reference = ReferenceGenerator.GenerateHashWithCounterReference(latestId);
            entity.UpdatedAt = DateTime.Now;
            entity.CreatedAt = DateTime.Now;

            entity.DataVersion = 1;

            await base.AddAsync(entity);
        }
    }
}
