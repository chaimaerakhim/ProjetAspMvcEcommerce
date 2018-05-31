using ProjetAspMvcEcommerce.Models;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace ProjetAspMvcEcommerce
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IServiceClients, ServiceClientsImp>();
            container.RegisterType<IServiceArticles, ServiceArticlesImp>();
            container.RegisterType<IServiceCategories, ServiceCategoriesImp>();
            container.RegisterType<IServiceCommandes, ServiceCommandesImp>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));


            GlobalConfiguration.Configuration.DependencyResolver = new  Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}