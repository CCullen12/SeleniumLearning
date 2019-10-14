using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_POM_Learning.Pages
{
    class GoogleHomePage
    {
        private IWebDriver driver;
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement GoogleSearchField;
        [FindsBy(How = How.Id, Using = "cnsd")]
        private IWebElement Remindmelater;
        public GoogleHomePage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        public void SendSearch()
        {
            GoogleSearchField.SendKeys("This is a simple test");
        }
        public string Result()
        {
            return Remindmelater.Text;
        }
    }
}
