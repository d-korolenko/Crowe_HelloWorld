using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;

namespace HelloWorld.Tests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void TestHelloWorldConsole()
        {
            MessengerConsole helloWorldConsole = new MessengerConsole();
            var expected = "CONSOLE: Hello World!";
            var actual = helloWorldConsole.GetMessage();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelloWorldDB()
        {
            MessengerDB helloWorldDB = new MessengerDB();
            var expected = "DB: Hello World!";
            var actual = helloWorldDB.GetMessage();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelloWorldMobile()
        {
            MessengerMobile helloWorldMobile = new MessengerMobile();
            var expected = "MOBILE: Hello World!";
            var actual = helloWorldMobile.GetMessage();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelloWorldWebApp()
        {
            MessengerWebApp helloWorldWebApp = new MessengerWebApp();
            var expected = "WEB APP: Hello World!";
            var actual = helloWorldWebApp.GetMessage();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelloWorldWinService()
        {
            MessengerWinService helloWorldWinService = new MessengerWinService();
            var expected = "WIN SERVICE: Hello World!";
            var actual = helloWorldWinService.GetMessage();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHelloWorldDefault()
        {
            MessengerDefault helloWorldDefault = new MessengerDefault();
            var expected = "DEFAULT: Hello World!";
            var actual = helloWorldDefault.GetMessage();
            Assert.AreEqual(expected, actual);
        }

    }
}
