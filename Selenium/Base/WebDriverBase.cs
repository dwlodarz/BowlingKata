using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
