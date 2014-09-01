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

        [When("I go to Environment module")]
        public void WhenIGoToEnvironmentModule()
        {

            ScenarioContext.Current.Pending();
        }

        [When(@"I open Environment Management")]
        public void WhenIOpenEnvironmentManagement()
        {
            ScenarioContext.Current.Pending();
        }


        [Then("list of running environments will be displayed")]
        public void ThenListOfRunnintEnvironmentsWillBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
