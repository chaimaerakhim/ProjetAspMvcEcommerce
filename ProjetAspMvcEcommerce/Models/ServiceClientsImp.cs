using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetAspMvcEcommerce.Models
{
    public class ServiceClientsImp : IServiceClients
    {
        private EcommerceProjetEntities db = new EcommerceProjetEntities();
        public void deleteClient(int id)
        {
            db.Clients.Remove(getClient(id));
            db.SaveChanges();
        }

        public Client getClient(int? id)
        {
            return db.Clients.Find(id);
        }

        public Client getClient(string login)
        {
            return db.Clients.Where(a => a.Login == login).SingleOrDefault();
        }

        public IEnumerable<Client> getClients()
        {
            return db.Clients.ToList();
        }

        public void postClient(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
        }

        public void putClient(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}