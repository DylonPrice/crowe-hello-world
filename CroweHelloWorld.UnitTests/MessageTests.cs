using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHelloWorld.WebAPI.Controllers;

namespace CroweHelloWorld.UnitTests
{
    [TestClass]
    public class MessageTests
    {
        private string expectedResult = "Hello World";

        [TestMethod]
        public void ConsoleGetMessage_ShouldReturnHelloWorld()
        {
            var controller = new ConsoleAppController();
            var message = controller.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void MobileGetMessage_ShouldReturnHelloWorld()
        {
            var controller = new MobileAppController();
            var message = controller.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WebGetMessage_ShouldReturnHelloWorld()
        {
            var controller = new WebAppController();
            var message = controller.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WinServiceGetMessage_ShouldReturnHelloWorld()
        {
            var controller = new WindowsServiceController();
            var message = controller.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }
    }
}
