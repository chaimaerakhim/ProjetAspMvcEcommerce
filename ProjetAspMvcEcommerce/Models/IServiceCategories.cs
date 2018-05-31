using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAspMvcEcommerce.Models
{
   public  interface IServiceCategories

    {
        IEnumerable<Categorie> getCategories();
        Categorie getCategorie(int? id);
        void putCategorie(Categorie categorie);
        void postCategorie(Categorie categorie);
        void deleteCategorie(Categorie categorie);
        IEnumerable<Article> getArticlesOfCategorie(int id);



    }
}
