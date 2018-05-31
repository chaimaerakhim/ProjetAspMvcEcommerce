using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAspMvcEcommerce.Models
{
    public interface IServiceArticles
    {
        IEnumerable<Article> getArticles();
        IEnumerable<Article> getArticlesPrixAsc(int nbrToShow, int id);
        IEnumerable<Article> getArticlesPrixDesc(int nbrToShow, int id);
        IEnumerable<Article> getArticlesNameAsc(int nbrToShow, int id);
        IEnumerable<Article> getArticlesNameDesc(int nbrToShow, int id);
        Article getArticle(int? id);
        void putArticle(Article article);

        void postArticle(Article article);
        void deleteArticle(int id);

    }
    
}
