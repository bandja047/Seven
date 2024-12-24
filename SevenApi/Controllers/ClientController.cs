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
    public class ClientController : ControllerBase
    {
        

        ClientRepositorie   _clientRepositorie;
    

        public ClientController(ClientRepositorie repositorie)
        {
           
            _clientRepositorie = repositorie;
            
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var list = await _clientRepositorie.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, list);
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var Client = await _clientRepositorie.GetByIdAsync(id);

            if (Client == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "Aucun n'Client a trouver" });
            }

            return StatusCode(StatusCodes.Status200OK, Client);
        }

     

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, ClientUpdateDto Client)
        {


            if (id != Client.Id)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new { message = "An error occurred.", details = "" });
            }

            



            var fournissuerItem = Mapper.Map<ClientUpdateDto, Client>(Client);


            fournissuerItem.UpdatedAt = DateTime.Now;
            fournissuerItem.DataVersion = fournissuerItem.DataVersion + 1;
           


           

            try
            {
                 var result =  await _clientRepositorie.UpdateAsync(fournissuerItem);

                if(!result)
                    return StatusCode(StatusCodes.Status404NotFound, new { message = "An error occurred.", details = "Client non trouver" });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostClient(ClientCreateDto ClientDto)
        {
            
            try
            {

                // Vérifier et générer une référence pour l'Client
             

                Client Client = Mapper.Map<ClientCreateDto, Client>(ClientDto);

                await _clientRepositorie.AddAsync(Client);

                return CreatedAtAction("GetCategorie", new { id = Client.Id }, Client);
            }
            catch (Exception ex)
            {
                // Rollback de la transaction en cas d'erreur
               
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An error occurred.", details = ex.Message });
            }
        }


        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                bool isRemove = await _clientRepositorie.DeleteAsync(id);

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

        private bool ClientExists(int id)
        {
            return _clientRepositorie.Exists(e=>e.Id == id);
        }
    }
}
