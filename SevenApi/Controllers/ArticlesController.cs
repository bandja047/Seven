using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seven.ContextDb;
using Seven.DataTransfertObject;
using Seven.Models;
using Seven.NewFolder;

namespace Seven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly SevenContext _context;

        public ArticlesController(SevenContext context)
        {
            _context = context;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> Getarticles()
        {
            return await _context.Articles.ToListAsync();
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, ArticleUpdateDto article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }

            var articleItem = await _context.Articles.FindAsync(id);
            if (articleItem == null) { 
            
                return NotFound();
            }


                
                
                articleItem. Name = article.Name;
              
                articleItem. UpdatedAt = DateTime.Now;
                articleItem. Description = article.Description;
                articleItem. PrixVente = article.PrixVente;
                articleItem.  PrixAchat = article.PrixAchat;
                articleItem. Quantite = article.Quantite;
                articleItem. UniteVente = article.UniteVente;
                articleItem. DataVersion = articleItem.DataVersion + 1 ;
                articleItem.CategorieId = article.CategorieId;

           
            _context.Entry(articleItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Article>> PostArticle(ArticleCreateDto article)
        {
            var id = _context.Articles.OrderByDescending(c => c.Id).FirstOrDefault()?.Id??0;

            var articleItem = new Article
            {
               
                Reference = $"{ReferenceGenerator.GenerateHashWithCounterReference(id)}",
                Name = article.Name,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                Description = article.Description,
                PrixVente = article.PrixVente,
                PrixAchat = article.PrixAchat,
                Quantite = article.Quantite,
                UniteVente = article.UniteVente,
                DataVersion = 1,
                CategorieId = article.CategorieId,
                

            };

            _context.Articles.Add(articleItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArticle), new { id = articleItem.Id }, articleItem);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
