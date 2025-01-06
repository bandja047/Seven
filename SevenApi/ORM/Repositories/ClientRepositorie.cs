using MotherStoreApi.ContextDb;
using MotherStoreBO.Models;
using MotherStoreApi.NewFolder;
using MotherStoreApi.Helpers;

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

        public override async Task<bool> UpdateAsync(Client entity)
        {
            var Item = await GetEntityAsNoTrackAsync(x => x.Id == entity.Id);

            if (Item == null)
            {
                return false;
            }

            Item = Mapper.Map<Client, Client>(entity);

            Item.UpdatedAt = DateTime.Now;
            Item.DataVersion = entity.DataVersion + 1;


            return await base.UpdateAsync(Item);
        }
    }
}
