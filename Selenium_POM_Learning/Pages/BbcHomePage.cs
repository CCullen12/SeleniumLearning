using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_POM_Learning.Pages
{
    public class BbcHomePage
    {
        private IWebDriver driver;
        public BbcHomePage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.Id,Using = "idcta-link")]
        private IWebElement SigninLink;
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.co.uk");
        }
        public void ClickSigninLink()
        {
            SigninLink.Click();
        }
    }
}
