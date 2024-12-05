using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Seven.ContextDb;
using Seven.DataTransfertObject;
using Seven.Helpers;
using Seven.Models;
using Seven.NewFolder;

namespace Seven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SevenContext _context;

        public CategoriesController(SevenContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorie>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> GetCategorie(int id)
        {
            var categorie = await _context.Categories.FindAsync(id);

            if (categorie == null)
            {
                return NotFound();
            }

            return categorie;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorie(int id, CategorieUpdateDao categorie)
        {
            if (id != categorie.Id)
            {
                return BadRequest();
            }

            if(id == categorie.ParentCategorieId)
            {
                return BadRequest();
            }

            var categorieToUpdate = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (categorieToUpdate == null) { 
            
                return NotFound();
            }

            
            Categorie categorie1 = Mapper.Map<CategorieUpdateDao, Categorie>(categorie);

            categorieToUpdate.UpdatedAt = DateTime.Now;
            categorieToUpdate.DataVersion = categorie.DataVersion + 1;
            categorieToUpdate.Name = categorie.Name;
            categorieToUpdate.ParentCategorieId = categorie.ParentCategorieId;

            _context.Entry(categorieToUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categorie>> PostCategorie(CategorieCreateDao categorieDao)
        {
            var id = _context.Categories.OrderByDescending(c => c.Id).FirstOrDefault()?.Id??0;

            if (categorieDao.ParentCategorieId != null)
            {
                if (!CategorieExists(categorieDao.ParentCategorieId)) 
                    return BadRequest();
            }

            Categorie categorie =  Mapper.Map<CategorieCreateDao, Categorie>(categorieDao);
            categorie.Reference = $"{id}{ReferenceGenerator.GenerateTimeStampedReference()}";
            categorie.UpdatedAt = DateTime.Now;
            categorie.CreatedAt = DateTime.Now;        

         

            _context.Categories.Add(categorie);
           /* var entry =  _context.ChangeTracker.Entries<Categorie>().Where(x=>x.State== EntityState.Added).FirstOrDefault();
            int id = entry.Entity.Id;*/
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorie", new { id = categorie.Id }, categorie);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {
            var categorie = await _context.Categories.FindAsync(id);
            if (categorie == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(categorie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategorieExists(int? id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
