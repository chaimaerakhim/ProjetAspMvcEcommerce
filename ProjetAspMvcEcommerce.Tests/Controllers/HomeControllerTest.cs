using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetAspMvcEcommerce;
using ProjetAspMvcEcommerce.Controllers;

namespace ProjetAspMvcEcommerce.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disposer
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Affirmer
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
