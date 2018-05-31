using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetAspMvcEcommerce.Models
{
    public class ServiceCategoriesImp : IServiceCategories
    {
        private EcommerceProjetEntities db = new EcommerceProjetEntities();
        public void deleteCategorie(Categorie categorie)
        {
            db.Categories.Remove(categorie);
            db.SaveChanges();
        }

        public IEnumerable<Article> getArticlesOfCategorie(int id)
        {
            return db.Articles.Where(a => a.RefCat == id).ToList();
        }

        public Categorie getCategorie(int? id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Categorie> getCategories()
        {
            return db.Categories.ToList();
        }

        public void putCategorie(Categorie categorie)
        {
            db.Entry(categorie).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void postCategorie(Categorie categorie)
        {
            db.Categories.Add(categorie);
            db.SaveChanges();
        }


    }
}