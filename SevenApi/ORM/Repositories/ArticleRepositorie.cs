using SevenApi.ContextDb;
using SevenApi.Models;
using SevenApi.NewFolder;

namespace SevenApi.ORM.Repositories
{
    public class ArticleRepositorie : GenericRepository<Article>
    {
        public ArticleRepositorie(SevenContext context) : base(context)
        {
        }

        public override async Task AddAsync(Article entity)
        {

            var latestCategorieId = await MaxAsync(c => (int?)c.Id);

            entity.Reference = ReferenceGenerator.GenerateHashWithCounterReference(latestCategorieId);
            entity.UpdatedAt = DateTime.Now;
            entity.CreatedAt = DateTime.Now;         
           
            entity.DataVersion = 1;

            await base.AddAsync(entity);
        }
    }
}
