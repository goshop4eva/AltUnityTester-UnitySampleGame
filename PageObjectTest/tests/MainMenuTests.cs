using System;
using System.Threading;
using AltTester.AltTesterUnitySDK.Driver;
using PageObjectTest.pages;
using NUnit.Framework;
namespace PageObjectTest.tests
{
    public class MainMenuTests
    {
        AltDriver altDriver;
        MainMenuPage mainMenuPage;
        [SetUp]
        public void Setup()
        {
            altDriver = new AltDriver(port: 13000);
            mainMenuPage = new MainMenuPage(altDriver);
            mainMenuPage.LoadScene();
        }

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }

        [Test]
        public void TestMainMenuPageLoadedCorrectly()
        {
            Assert.True(mainMenuPage.IsDisplayed());
        }
    }
}