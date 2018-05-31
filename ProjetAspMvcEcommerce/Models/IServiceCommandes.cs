using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAspMvcEcommerce.Models
{
    public interface IServiceCommandes
    {
        IEnumerable<Commande> getCommandes();
        Commande getCommande(int? id);
        void putCommande(Commande commande);
        void postCommande(Commande commande);
        void deleteCommande(int id);
    }
}
