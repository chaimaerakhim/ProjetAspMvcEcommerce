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
    public class ServiceArticlesController : ApiController
    {
        IServiceArticles serviceArticles;
        public ServiceArticlesController()
        {

        }
        public ServiceArticlesController(IServiceArticles serviceArticles)
        {
            this.serviceArticles = serviceArticles;
        }

        [Route("api/ArticleService/action1")]
        // GET: api/Articles
        public IEnumerable<Article> GetArticles()
        {
            return serviceArticles.getArticles();
        }

        [Route("api/ArticleService/action2")]
        // GET: api/Articles/5
        [ResponseType(typeof(Article))]
        public IHttpActionResult GetArticle(int? id)
        {
            Article article = serviceArticles.getArticle(id);
            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }

        [Route("api/ArticleService/action4")]
        // PUT: api/Articles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                serviceArticles.putArticle(article);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (serviceArticles.getArticle(article.NumArticle) == null)
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

        [Route("api/ArticleService/action3")]
        // POST: api/Articles
        [ResponseType(typeof(Article))]
        public IHttpActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            serviceArticles.postArticle(article);

            return CreatedAtRoute("GetArticle", new { controller = "ServiceArticles", id = article.NumArticle }, article);
        }

        [Route("api/ArticleService/action6")]
        // DELETE: api/Articles/5
        [ResponseType(typeof(Article))]
        public IHttpActionResult DeleteArticle(int id)
        {
            Article article = serviceArticles.getArticle(id);
            if (article == null)
            {
                return NotFound();
            }
            serviceArticles.deleteArticle(id);

            return Ok(article);
        }

        public IEnumerable<Article> GetArticlesPrixAsc(int nbrToShow, int id)
        {
            return serviceArticles.getArticlesPrixAsc(nbrToShow, id);
        }

        public IEnumerable<Article> GetArticlesPrixDesc(int nbrToShow, int id)
        {
            return serviceArticles.getArticlesPrixDesc(nbrToShow, id);
        }

        public IEnumerable<Article> GetArticlesNameAsc(int nbrToShow, int id)
        {
            return serviceArticles.getArticlesNameAsc(nbrToShow, id);
        }

        public IEnumerable<Article> GetArticlesNameDesc(int nbrToShow, int id)
        {
            return serviceArticles.getArticlesNameDesc(nbrToShow, id);
        }
    }
}
