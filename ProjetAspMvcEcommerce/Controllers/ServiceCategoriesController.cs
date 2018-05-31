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
    public class ServiceCategoriesController : ApiController
    {
        IServiceCategories serviceCategories;

  
    public ServiceCategoriesController(IServiceCategories serviceCategories)
    {
        this.serviceCategories = serviceCategories;
    }


    [Route("api/CategorieService/action1")]
    // GET: api/Categories
    public IEnumerable<Categorie> GetCategories()
    {
        return serviceCategories.getCategories();
    }

    [Route("api/CategorieService/action2")]
    // GET: api/Categories/5
    [ResponseType(typeof(Categorie))]
    public IHttpActionResult GetCategorie(int? id)
    {
        Categorie categorie = serviceCategories.getCategorie(id);
        if (categorie == null)
        {
            return NotFound();
        }

        return Ok(categorie);
    }
    [Route("api/CategorieService/action4")]
    // PUT: api/Categories/5
    [ResponseType(typeof(void))]
    public IHttpActionResult PutCategorie(Categorie categorie)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            serviceCategories.putCategorie(categorie);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (serviceCategories.getCategorie(categorie.RefCat) == null)
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
    [Route("api/CategorieService/action3")]
    // POST: api/Categories
    [ResponseType(typeof(Categorie))]
    public IHttpActionResult PostCategorie(Categorie categorie)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        serviceCategories.postCategorie(categorie);

        return CreatedAtRoute("GetCategorie", new { controller = "ServiceCategories", id = categorie.RefCat }, categorie);
    }
    [Route("api/CategorieService/action6")]
    // DELETE: api/Categories/5
    [ResponseType(typeof(Categorie))]
    public IHttpActionResult DeleteCategorie(int id)
    {
        Categorie categorie = serviceCategories.getCategorie(id);
        if (categorie == null)
        {
            return NotFound();
        }

        serviceCategories.deleteCategorie(categorie);

        return Ok(categorie);
    }



    public IEnumerable<Article> GetArticlesOfCategorie(int id)
    {
        return serviceCategories.getArticlesOfCategorie(id);
    }
}
}
