using OpenQA.Selenium;
using Selenium.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selenium.TestSteps
{
    class MainPage : WebDriverBase
    {
        public MainPage(IWebDriver _driver)
            :base(_driver)
        {
        }

        public void Open(String url){
            _goToURL(url);
        }
        
    }
}
