using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotherStoreApi.ContextDb;
using MotherStoreBO.DataTransfertObject;
using MotherStoreApi.Helpers;
using MotherStoreBO.Models;
using MotherStoreApi.NewFolder;
using MotherStoreApi.ORM.Repositories;

namespace MotherStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseurController : ControllerBase
    {
        

        FournisseurRepositorie   _fournisseurRepositorie;
    

        public FournisseurController(FournisseurRepositorie repositorie)
        {
           
            _fournisseurRepositorie = repositorie;
            
        }

        // GET: api/Fournisseurs
        [HttpGet]
        public async Task<IActionResult> GetFournisseurs()
        {
            var list = await _fournisseurRepositorie.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, list);
        }

        // GET: api/Fournisseurs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFournisseur(int id)
        {
            var Fournisseur = await _fournisseurRepositorie.GetByIdAsync(id);

            if (Fournisseur == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "Aucun n'fournisseur a trouver" });
            }

            return StatusCode(StatusCodes.Status200OK, Fournisseur);
        }

     

        // PUT: api/Fournisseurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFournisseur(int id, FournisseurUpdateDto fournisseur)
        {


            if (id != fournisseur.Id)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new { message = "An error occurred.", details = "" });
            }

            



            var fournissuerItem = Mapper.Map<FournisseurUpdateDto, Fournisseur>(fournisseur);


            fournissuerItem.UpdatedAt = DateTime.Now;
            fournissuerItem.DataVersion = fournissuerItem.DataVersion + 1;
           


           

            try
            {
                 var result =  await _fournisseurRepositorie.UpdateAsync(fournissuerItem);

                if(!result)
                    return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "fournisseur non trouver" });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FournisseurExists(id))
                {
                    return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "" });
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(StatusCodes.Status200OK, fournissuerItem);
        }

        // POST: api/Fournisseurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostFournisseur(FournisseurCreateDto fournisseurDto)
        {
            
            try
            {

                // Vérifier et générer une référence pour l'fournisseur
             

                Fournisseur fournisseur = Mapper.Map<FournisseurCreateDto, Fournisseur>(fournisseurDto);

                await _fournisseurRepositorie.AddAsync(fournisseur);

                return CreatedAtAction("GetFournisseur", new { id = fournisseur.Id }, fournisseur);
            }
            catch (Exception ex)
            {
                // Rollback de la transaction en cas d'erreur
               
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An error occurred.", details = ex.Message });
            }
        }


        // DELETE: api/Fournisseurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFournisseur(int id)
        {
            try
            {
                bool isRemove = await _fournisseurRepositorie.DeleteAsync(id);

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

        private bool FournisseurExists(int id)
        {
            return _fournisseurRepositorie.Exists(e=>e.Id == id);
        }
    }
}
