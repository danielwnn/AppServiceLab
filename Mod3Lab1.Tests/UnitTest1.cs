using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod3Lab1.Controllers;

namespace Mod3Lab1.Tests
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
