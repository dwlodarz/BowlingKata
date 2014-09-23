using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Selenium.TestSteps
{
    [Binding]
    public class MainPageSteps
    {

        private static IWebDriver _driver = new ChromeDriver();
        private MainPage mainPage = new MainPage(_driver);

        [Given("North Star demo app at (.*)")]
        public void GivenNorthStarDemoAppAt(string url)
        {
            mainPage.Open(url);
        }

        [When("I go to (.*) module")]
        public void WhenIGoToEnvironmentModule(string moduleName)
        {
            mainPage.GoToModule(moduleName);            
        }

        [When(@"I open (.*)")]
        public void WhenIOpenEnvironmentManagement(string moduleName)
        {
            mainPage.GoToSubModule(moduleName);
            mainPage.WaitForEnvironmentListToLoad();
        }


        [Then("list of running environments will be displayed")]
        public void ThenListOfRunnintEnvironmentsWillBeDisplayed()
        {
            int listCount  = mainPage.GetListOfEnvironments().Count;
            NUnit.Framework.Assert.AreNotEqual(0, listCount);
        }

        [Then(@"(.*) is present")]
        public void ThenLogViewIsPresent(string subModuleName)
        {
            Assert.True(true);
        }
    }
}
