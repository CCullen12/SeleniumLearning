using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_POM_Learning.Pages;

namespace Selenium_POM_Learning
{
    [TestFixture]
    class TestingClass
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void BBCSignInError()
        {
            BbcHomePage bbcHomePage = new BbcHomePage(driver);
            BbcSigninPage bbcSigninPage = new BbcSigninPage(driver);
            bbcHomePage.GoToPage();
            bbcHomePage.ClickSigninLink();
            bbcSigninPage.TypeUserName("maigbodi@gmail.com");
            bbcSigninPage.TypePassword("123456789");
            bbcSigninPage.ClickSigninLink();
            string result = bbcSigninPage.CheckResult();
            StringAssert.Contains(result, "Sorry, that password isn't valid. Please include a letter.");
        }
        [Test]
        public void GoogleSearchTest()
        {
            GoogleHomePage googleHomePage = new GoogleHomePage(driver);
            googleHomePage.GoToPage();
            googleHomePage.SendSearch();
            string result = googleHomePage.Result();
            StringAssert.Contains(result, "REMIND ME LATER");
        }
        [Test]
        public void GuruHomePageTest()
        {
            GuruSigninPage gurusignin = new GuruSigninPage(driver);
            gurusignin.GoToPage();
            string result = gurusignin.ResultHomePage();
            StringAssert.Contains(result, "Guru99 Bank");
        }
        [Test]
        public void GuruLoginTest()
        {
            GuruSigninPage gurusignin = new GuruSigninPage(driver);
            gurusignin.GoToPage();
            gurusignin.SendUserName();
            gurusignin.SendUserPassword();
            gurusignin.ClickSubmit();
            string result = gurusignin.ResultLogin();
            StringAssert.Contains(result, "Welcome To Manager's Page of Guru99 Bank");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
