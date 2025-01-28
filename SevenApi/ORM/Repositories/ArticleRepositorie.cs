using Microsoft.EntityFrameworkCore;
using MotherStoreApi.ContextDb;
using MotherStoreApi.Helpers;
using MotherStoreBO.Models;
using MotherStoreApi.NewFolder;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Mvc;
using MotherStoreBO.DataTransfertObject;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MotherStoreApi.ORM.Repositories
{
    public class ArticleRepositorie : GenericRepository<Article>
    {
        public DatabaseFacade Database { get; set; }
        public ArticleRepositorie(MotherStoreContext context) : base(context)
        {
            Database = context.Database;
        }

        public async Task PostArticle(Article article)
        {
            
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {

                // Vérifier et générer une référence pour l'article
                var latestArticleId = await MaxAsync(c => (int?)c.Id);
                var _categorieRepos = new CategorieRepositorie(_context);

                // Rechercher la catégorie
                var categorie = (await _categorieRepos.FindOneAsync(c => c.Id == article.Categories.Id));

                if (categorie == null)
                {
                    // Créer une nouvelle catégorie si elle n'existe pas


                    var newCategorie = Mapper.Map<Categorie, Categorie>(article.Categories);
                    await _categorieRepos.AddAsync(newCategorie);
                    await _context.SaveChangesAsync(); // Sauvegarder pour générer l'ID

                    categorie = newCategorie; // Mettre à jour la référence
                }

                // Créer un nouvel article
                var newArticle = Mapper.Map<Article, Article>(article);
                newArticle.CategorieId = categorie.Id;



                await  AddAsync(newArticle);
                await _context.SaveChangesAsync(); // Sauvegarder pour persister l'article

                // Commit de la transaction
                await transaction.CommitAsync();

                // Retourner l'article créé
               
            }
            catch (Exception )
            {
                // Rollback de la transaction en cas d'erreur
                await transaction.RollbackAsync();
                throw ;
            }
        }
        public override async Task AddAsync(Article entity)
        {
            await PostArticle(entity);

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
