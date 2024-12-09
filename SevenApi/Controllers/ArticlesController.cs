using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SevenApi.ContextDb;
using SevenApi.DataTransfertObject;
using SevenApi.Helpers;
using SevenApi.Models;
using SevenApi.NewFolder;
using SevenApi.ORM.Repositories;

namespace SevenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly SevenContext _context;

        ArticleRepositorie _articleRepos;
        CategorieRepositorie _categorieRepos;

        public ArticlesController(SevenContext context, ArticleRepositorie article, CategorieRepositorie categorieR)
        {
            _context = context;
            _articleRepos = article;
            _categorieRepos = categorieR;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<IActionResult> Getarticles()
        {
            return StatusCode(StatusCodes.Status302Found, await _articleRepos.GetAllAsync());
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(int id)
        {
            var article = await _articleRepos.GetByIdAsync(id);

            if (article == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "Aucun n'article a trouver" });
            }

            return StatusCode(StatusCodes.Status302Found, article);
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, ArticleUpdateDto article)
        {


            if (id != article.Id)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new { message = "An error occurred.", details = "" });
            }

            var articleItem = await _articleRepos.GetByIdAsync(id);

            if (articleItem == null)
            {

                return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "article non trouver" });
            }



            articleItem = Mapper.Map<ArticleUpdateDto, Article>(article);       

          
            articleItem.UpdatedAt = DateTime.Now;           
            articleItem.DataVersion = articleItem.DataVersion + 1;
           


           

            try
            {
               await _articleRepos.UpdateAsync(articleItem);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "" });
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(StatusCodes.Status200OK,articleItem);
        }

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostArticle(ArticleCreateDto article)
        {
            if (article == null || article.Categorie == null)
            {
                return BadRequest(new { message = "Invalid article or category data." });
            }

            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {

                // Vérifier et générer une référence pour l'article
                var latestArticleId = await _articleRepos.MaxAsync(c => (int?)c.Id);

                // Rechercher la catégorie
                var categorie = (await _categorieRepos.FindOneAsync(c => c.Id == article.Categorie.Id));

                if (categorie == null)
                {
                    // Créer une nouvelle catégorie si elle n'existe pas


                    var newCategorie = Mapper.Map<CategorieUpdateDao, Categorie>(article.Categorie);
                    await _categorieRepos.AddAsync(newCategorie);
                    await _context.SaveChangesAsync(); // Sauvegarder pour générer l'ID

                    categorie = newCategorie; // Mettre à jour la référence
                }

                // Créer un nouvel article
                var newArticle = Mapper.Map<ArticleCreateDto, Article>(article);
                newArticle.CategorieId = categorie.Id;



                await _articleRepos.AddAsync(newArticle);
                await _context.SaveChangesAsync(); // Sauvegarder pour persister l'article

                // Commit de la transaction
                await transaction.CommitAsync();

                // Retourner l'article créé
                return CreatedAtAction(nameof(GetArticle), new { id = newArticle.Id }, newArticle);
            }
            catch (Exception ex)
            {
                // Rollback de la transaction en cas d'erreur
                await transaction.RollbackAsync();
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An error occurred.", details = ex.Message });
            }
        }


        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            try
            {
                bool isRemove = await _articleRepos.DeleteAsync(id);

                if (isRemove)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }

                return  StatusCode(StatusCodes.Status304NotModified, new { message = "An error occurred.", details = "" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status304NotModified, new { message = "An error occurred.", details = ex.Message });
            }

           
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
