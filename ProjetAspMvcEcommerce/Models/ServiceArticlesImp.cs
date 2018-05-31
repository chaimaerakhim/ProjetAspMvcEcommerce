using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetAspMvcEcommerce.Models
{
    public class ServiceArticlesImp : IServiceArticles
    {
        public EcommerceProjetEntities db = new EcommerceProjetEntities();
        private Article article;

        public void deleteArticle(int id)
        {
            db.Articles.Remove(article);
            db.SaveChanges();

        }

        public Article getArticle(int? id)
        {
            return db.Articles.Find(id);
        }

        public IEnumerable<Article> getArticles()
        {
            return db.Articles.ToList();
        }

        public IEnumerable<Article> getArticlesNameAsc(int nbrToShow, int id)
        {

            return db.Articles.Where(a => a.RefCat == id).OrderBy(a => a.Designation).Take(nbrToShow);

        }

        public IEnumerable<Article> getArticlesNameDesc(int nbrToShow, int id)
        {
            return db.Articles.Where(a => a.RefCat == id).OrderByDescending(a => a.Designation).Take(nbrToShow);

        }

        public IEnumerable<Article> getArticlesPrixAsc(int nbrToShow, int id)
        {
            return db.Articles.Where(a => a.RefCat == id).OrderBy(a => a.PrixU).Take(nbrToShow);

        }

        public IEnumerable<Article> getArticlesPrixDesc(int nbrToShow, int id)
        {

            return db.Articles.Where(a => a.RefCat == id).OrderByDescending(a => a.PrixU).Take(nbrToShow);

        }

        public void postArticle(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
        }

        public void putArticle(Article article)
        {
            db.Entry(article).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool ArticleExists(int id)
        {
            return db.Articles.Count(e => e.NumArticle == id) > 0;
        }

    }
}