using Microsoft.EntityFrameworkCore;
using MotherStoreApi.ContextDb;
using MotherStoreApi.Helpers;
using MotherStoreApi.Models;
using MotherStoreApi.NewFolder;
using System.Security.Cryptography.Xml;

namespace MotherStoreApi.ORM.Repositories
{
    public class ArticleRepositorie : GenericRepository<Article>
    {
        public ArticleRepositorie(MotherStoreContext context) : base(context)
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

        public  async Task<List<Article>> GetWithCategoriesAsync(int id)
        {

            var categorie = await _dbSet.Where(x => x.Id == id)
                .Include(y => y.Categories).
                Select(a => Mapper.Map<Article, Article>(a)).ToListAsync();


            return categorie;
        }

        public async Task<List<Article>> GetWithCategoriesAsync()
        {
           

            var categories = await _dbSet
                .Include(y => y.Categories).
                Select(a => Mapper.Map<Article,Article>(a)).ToListAsync();


            return categories;
        }

        public override async Task<bool> UpdateAsync(Article entity)
        {
            var articleItem = await GetEntityAsNoTrackAsync(c=>c.Id == entity.Id);

           
            if (articleItem == null) { 
                return false;
            }
            articleItem = Mapper.Map<Article, Article>(entity);
            articleItem.UpdatedAt = DateTime.Now;
            articleItem.DataVersion = entity.DataVersion + 1;

            return await base.UpdateAsync(articleItem);
        }
    }
}
