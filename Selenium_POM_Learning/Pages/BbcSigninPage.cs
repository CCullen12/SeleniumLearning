using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_POM_Learning.Pages
{
    public class BbcSigninPage
    {
        private IWebDriver driver;
        public BbcSigninPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        private IWebElement UserNameField;
        [FindsBy(How = How.Id, Using = "password-input")]
        private IWebElement PasswordField;
        [FindsBy(How = How.Id, Using = "submit-button")]
        private IWebElement SigninButton;

        [FindsBy(How = How.Id, Using = "form-message-password")]
        private IWebElement LoginResult;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://account.bbc.com/signin");
        }

        public void TypeUserName(string username)
        {
            UserNameField.SendKeys(username);
        }
        public void TypePassword(string password)
        {
            PasswordField.SendKeys(password);
        }
        public void ClickSigninLink()
        {
            SigninButton.Click();
        }
        public string CheckResult()
        {
            return LoginResult.Text;
        }
    }
}
