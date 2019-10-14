using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_POM_Learning.Pages
{
    class GuruSigninPage
    {

        private IWebDriver driver;


        [FindsBy(How = How.ClassName, Using = "barone")]
        private IWebElement GuruBankCheck;
        [FindsBy(How = How.Name, Using = "uid")]
        private IWebElement SigninUser;
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement PasswordSingin;
        [FindsBy(How = How.Name, Using = "btnLogin")]
        private IWebElement SubmitLogin;
        [FindsBy(How = How.ClassName, Using = "heading3")]
        private IWebElement LoginSuccessCheck;
        //Welcome To Manager's Page of Guru99 Bank
        public GuruSigninPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://demo.guru99.com/v4/");
        }
        public void SendUserName()
        {
            SigninUser.SendKeys("mgr123");
        }
        public void SendUserPassword()
        {
            PasswordSingin.SendKeys("mgr!23");
        }
        public void ClickSubmit()
        {
            SubmitLogin.Click();
        }
        
        public string ResultHomePage()
        {
            return GuruBankCheck.Text;
        }
        public string ResultLogin()
        {
            return LoginSuccessCheck.Text;
        }
    }
}
