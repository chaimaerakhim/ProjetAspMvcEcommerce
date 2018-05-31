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
    public class ServiceClientsController : ApiController
    {
        public IServiceClients serviceClients;

        public ServiceClientsController(IServiceClients serviceClients)
        {
            this.serviceClients = serviceClients;
        }

        [Route("api/ClientService/action1")]
        // GET: api/Clients
        public IEnumerable<Client> GetClients()
        {
            return serviceClients.getClients();
        }

        [Route("api/ClientService/action2")]
        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int? id)
        {
            Client client = serviceClients.getClient(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [Route("api/ClientService/action4")]
        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                serviceClients.putClient(client);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (serviceClients.getClient(client.NumClient) == null)
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
        [Route("api/ClientService/action3")]
        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            serviceClients.postClient(client);

            return CreatedAtRoute("GetClient", new { controller = "ServiceClients", id = client.NumClient }, client);
        }
        [Route("api/ClientService/action6")]
        // DELETE: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = serviceClients.getClient(id);
            if (client == null)
            {
                return NotFound();
            }

            serviceClients.deleteClient(id);
            return Ok(client);
        }


        public IHttpActionResult GetClient(string login)
        {
            Client client = serviceClients.getClient(login);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }
    }
}
