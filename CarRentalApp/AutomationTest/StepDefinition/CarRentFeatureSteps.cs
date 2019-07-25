using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationTest.StepDefinition
{
    [Binding]
    public class CarRentFeatureSteps
    {
        IWebDriver driver;

        [Given(@"chrome instance is open")]
        public void GivenChromeInstanceIsOpen()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.FullScreen();
        }

        [When(@"set the url")]
        public void WhenSetTheUrl()
        {
            driver.Url = "http://localhost:60711/home";
        }

        [When(@"set the url (.*)")]
        public void WhenSetTheUrl(string url)
        {
            driver.Url = url;
        }

        [Then(@"car rent logo is displayed")]
        public void ThenCarRentLogoIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div[2]/div/table/tbody/tr[1]/td[1]/img"));
            Assert.IsTrue(element != null);

            driver.Close();
        }

        [Then(@"'(.*)' label is displayed")]
        public void ThenLabelIsDisplayed(string label)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div[1]/p[1]"));
            Assert.AreEqual(label, element.Text);
            driver.Close();
        }

        [Then(@"age checkbox is enabled")]
        public void ThenAgeCheckboxIsEnabled()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"defaultUnchecked\"]"));
            Assert.IsTrue(element.Enabled);
        }

        [Then(@"the label is '(.*)'")]
        public void ThenTheLabelIs(string label)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div[1]/div/label"));
            Assert.AreEqual(label, element.Text);
            driver.Close();
        }

        [Then(@"the below tabs are available")]
        public void ThenTheBelowTabsAreAvailable(Table table)
        {
            foreach (var row in table.Rows)
            {
                IWebElement element;

                switch (row["tabs"].ToLower())
                {
                    case "home":
                        // //*[@id="navbarResponsive"]/ul/li[1]/a
                        element = driver.FindElement(By.XPath("//*[@id=\"navbarResponsive\"]/ul/li[1]"));

                        break;

                    case "view all cars":
                        element = driver.FindElement(By.XPath("//*[@id=\"navbarResponsive\"]/ul/li[2]/a"));

                        break;

                    case "contact":
                        element = driver.FindElement(By.XPath("//*[@id=\"navbarResponsive\"]/ul/li[3]/a"));

                        break;

                    default:
                        Assert.Fail("unexpected tab was received " + row["tabs"]);
                        element = null;
                        break;
                }

                Assert.AreEqual(row["tabs"], element.Text);
                driver.Close();
            }
        }




    }
}
