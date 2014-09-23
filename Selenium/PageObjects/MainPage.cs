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
        
        public void GoToModule(string moduleName)
        {
            _clickOnLink(moduleName);
        }
        public void GoToSubModule(string moduleName)
        {

            _clickOnXpath(@"//li/div/a[contains(.,'"+ moduleName +"')]");
        }
        
        internal void WaitForEnvironmentListToLoad()
        {
            _waitForElementPresent("//h3[contains(.,'Environment list')]", 15);
        }
        public List<String> GetListOfEnvironments()
        {
            var lista=_driver.FindElements(By.XPath(@"//*[@id='dataTable']//tr/td[1]"));
            List<String> listaStr = new List<string>();
            for (int i = 1; i < lista.Count; i++)
            {
                listaStr.Add(lista[i].Text);
               
            }
            return listaStr;
        }

    }
}
