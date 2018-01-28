using Microsoft.VisualStudio.TestTools.UnitTesting;
using continousweb.Controllers;

namespace ContonousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
