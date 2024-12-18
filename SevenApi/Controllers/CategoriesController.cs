using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MotherStoreApi.ContextDb;
using MotherStoreApi.DataTransfertObject;
using MotherStoreApi.Helpers;
using MotherStoreApi.Models;
using MotherStoreApi.NewFolder;
using MotherStoreApi.ORM.Repositories;

namespace MotherStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MotherStoreContext _context;
        private readonly CategorieRepositorie _categorieRepos;

        public CategoriesController(MotherStoreContext context, CategorieRepositorie categorieRepos)
        {
            _context = context;
            _categorieRepos = categorieRepos;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return StatusCode(StatusCodes.Status200OK, await _categorieRepos.GetAllAsync());
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> GetCategorie(int id)
        {
            var categorie = await _categorieRepos.GetByIdAsync(id);

            if (categorie == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "", Details = "Donnee non trouver" });
            }

            return  StatusCode(StatusCodes.Status200OK, categorie); ;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorie(int id, CategorieUpdateDao categorie)
        {
            if (id != categorie.Id)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new { Message = "", Details = "Invalid Id" });
            }

            if(id == categorie.ParentCategorieId)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new { Message = "", Details = "Invalid Id and parent id" });
            }

         
            
            Categorie categorie1 = Mapper.Map<CategorieUpdateDao, Categorie>(categorie);

            
          
        

          

            try
            {
               var result = await  _categorieRepos.UpdateAsync(categorie1);

                if(!result)
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "", Details = "Not Found" });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(id))
                {
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "", Details = "Not Found" });
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(StatusCodes.Status200OK, categorie1); 
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categorie>> PostCategorie(CategorieCreateDao categorieDao)
        {
            

            if (categorieDao.ParentCategorieId != null)
            {
                if (!CategorieExists(categorieDao.ParentCategorieId))
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "", Details = "Not Found Parent Categorie" });
            }

            Categorie categorie =  Mapper.Map<CategorieCreateDao, Categorie>(categorieDao);
           
            await _categorieRepos.AddAsync(categorie);

            return CreatedAtAction("GetCategorie", new { id = categorie.Id }, categorie);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {
            try
            {
                bool isRemove = await _categorieRepos.DeleteAsync(id);

                if (isRemove)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }

                return StatusCode(StatusCodes.Status304NotModified, new { message = "An error occurred.", details = "" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status304NotModified, new { message = "An error occurred.", details = ex.Message });
            }
        }

        private bool CategorieExists(int? id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
