using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium_Testing
{
    [TestFixture]
    public class SeleniumBbcLoginTest
    {
        [Test]
        public void SeleniumBbcWalkThrough()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //creates a browser window and maximizes it.
                driver.Manage().Window.Maximize();
                //Navigagete to the website under test.
                driver.Navigate().GoToUrl("https://www.bbc.co.uk");
                //Get the login button.
                IWebElement loginButton = driver.FindElement(By.Id("idcta-link"));
                loginButton.Click();
                //now in login page now get the usrname and password.
                IWebElement userNameField = driver.FindElement(By.Id("user-identifier-input"));
                userNameField.SendKeys("maigbodi@gmail.com");
                IWebElement PasswordField = driver.FindElement(By.Id("password-input"));
                PasswordField.SendKeys("123456789");
                //click the submit button.
                IWebElement SigninButton = driver.FindElement(By.Id("submit-button"));
                SigninButton.Click();
                //get the resulting txt
                IWebElement LoginResult = driver.FindElement(By.Id("form-message-password"));
                //run the test
                Assert.AreEqual("Sorry, that password isn't valid. Please include a letter.", LoginResult.Text);
            }
        }
        [Test]
        public void SeleniumGoogleWalkThrough()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //creates a browser window and maximizes it.
                driver.Manage().Window.Maximize();
                //Navigagete to the website under test.
                driver.Navigate().GoToUrl("https://www.google.com");
                //now in login page now get the usrname and password.
                IWebElement userNameField = driver.FindElement(By.Name("q"));
                userNameField.SendKeys("This is a simple test");
                //get the resulting txt
                IWebElement LoginResult = driver.FindElement(By.Id("cnsd"));
                //run the test
                Assert.AreEqual("REMIND ME LATER", LoginResult.Text);
            }
        }
    }
}