using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.Base
{
    public abstract class WebDriverBase
    {
        public readonly IWebDriver _driver;
        public WebDriverBase(IWebDriver driver)
        {
            this._driver = driver;
        }

        protected void _goToURL(string url)
        {
            _driver.Url= url;
            _driver.Navigate();
        }

        protected void _clickOnPartialLink(string moduleName)
        {
            int count = 0;
            while (_driver.FindElement(By.PartialLinkText(moduleName)) == null && count < 5) 
            {
                Thread.Sleep(1000);
                count++;
            }
            _driver.FindElement(By.PartialLinkText(moduleName)).Click();
            

        }

        protected void _clickOnLink(string moduleName)
        {
            int count = 0;
            while (_driver.FindElement(By.LinkText(moduleName)) == null && count < 5)
            {
                Thread.Sleep(1000);
                count++;
            }
            _driver.FindElement(By.LinkText(moduleName)).Click();


        }


        protected void _clickOnXpath(string p)
        {
            int count = 0;
            while (_driver.FindElement(By.XPath(p)).Displayed == false && count < 5)
            {
                Thread.Sleep(1000);
                count++;
            }

            _driver.FindElement(By.XPath(p)).Click();
        }

        protected void _waitForElementPresent(string xpath, int maxCounter)
        {
            int count = 0;
            while (_driver.FindElement(By.XPath(xpath)).Displayed == false && count < maxCounter)
            {
                Thread.Sleep(1000);
                count++;
            }
        }
    }
}
