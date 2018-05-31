using ProjetAspMvcEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProjetAspMvcEcommerce.Controllers
{
    public class ServiceCommandesController : ApiController
    {
        IServiceCommandes serviceCommandes;
        public ServiceCommandesController()
        {

        }
        public ServiceCommandesController(IServiceCommandes serviceCommandes)
        {
            this.serviceCommandes = serviceCommandes;
        }


        [Route("api/CommandeService/action1")]
        // GET: api/Commandes
        public IEnumerable<Commande> GetCommandes()
        {
            return serviceCommandes.getCommandes();
        }
        [Route("api/CommandeService/action2")]
        // GET: api/Commandes/5
        [ResponseType(typeof(Commande))]
        public IHttpActionResult GetCommande(int? id)
        {
            Commande commande = serviceCommandes.getCommande(id);
            if (commande == null)
            {
                return NotFound();
            }

            return Ok(commande);
        }
        [Route("api/CommandeService/action4")]
        // PUT: api/Commandes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCommande(Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                serviceCommandes.putCommande(commande);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (serviceCommandes.getCommande(commande.NumCmd) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        [Route("api/CommandeService/action3")]
        // POST: api/Commandes
        [ResponseType(typeof(Commande))]
        public IHttpActionResult PostCommande(Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            serviceCommandes.postCommande(commande);

            return CreatedAtRoute("GetCommande", new { controller = "ServiceCommandes", id = commande.NumCmd }, commande);
        }
        [Route("api/CommandeService/action6")]
        // DELETE: api/Commandes/5
        [ResponseType(typeof(Commande))]
        public IHttpActionResult DeleteCommande(int id)
        {
            Commande commande = serviceCommandes.getCommande(id);
            if (commande == null)
            {
                return NotFound();
            }

            serviceCommandes.deleteCommande(id);

            return Ok(commande);
        }




    }
}
