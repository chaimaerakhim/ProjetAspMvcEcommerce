using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetAspMvcEcommerce.Models
{
    public class ServiceCommandesImp : IServiceCommandes
    {
        private EcommerceProjetEntities db = new EcommerceProjetEntities();
        public void deleteCommande(int id)
        {
            db.Commandes.Remove(getCommande(id));
            db.SaveChanges();
        }

        public Commande getCommande(int? id)
        {
            return db.Commandes.Find(id);
        }

        public IEnumerable<Commande> getCommandes()
        {
            return db.Commandes.ToList();
        }

        public void postCommande(Commande commande)
        {
            db.Commandes.Add(commande);
            db.SaveChanges();
        }

        public void putCommande(Commande commande)
        {
            db.Entry(commande).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}