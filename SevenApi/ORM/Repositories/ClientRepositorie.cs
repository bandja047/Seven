using MotherStoreApi.ContextDb;
using MotherStoreApi.Models;
using MotherStoreApi.NewFolder;

namespace MotherStoreApi.ORM.Repositories
{
    public class ClientRepositorie : GenericRepository<Client>
    {
        public ClientRepositorie(MotherStoreContext context) : base(context)
        {

        }

        public override async Task AddAsync(Client entity)
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
