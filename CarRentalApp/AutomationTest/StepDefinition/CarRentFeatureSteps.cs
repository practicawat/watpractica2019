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

        public object IdWebElement { get; private set; }

        [Given(@"chrome instance is open")]
        public void GivenChromeInstanceIsOpen()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.FullScreen();
        }

        [When(@"set the url")]
        public void WhenSetTheUrl()
        {
            driver.Url = "http://localhost:59491/add-car-rental-page";
        }


        [Then(@"car rent logo is displayed")]
        public void ThenCarRentLogoIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div/div/div[1]/div/div/h5"));
            Assert.IsTrue(element != null);

            driver.Close();
        }

        [Then(@"'(.*)' label is displayed")]
        public void ThenLabelIsDisplayed(string label)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div/div/div[1]/div/div/h5"));
            Assert.AreEqual(label, element.Text);
            driver.Close();
        }

        [Then(@"age checkbox is enabled")]
        public void ThenAgeCheckboxIsEnabled()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"defaultUnchecked\"]"));
            Assert.IsTrue(element.Enabled);
            driver.Close();
        }

        [Then(@"the label is '(.*)'")]
        public void ThenTheLabelIs(string label)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-home-page/div/div/div[1]/div/div/div/label"));
            Assert.AreEqual(label, element.Text);
            driver.Close();
        }



        [Given(@"chrome instance is open on car rent")]
        public void GivenChromeInstanceIsOpenOnCarRent()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.FullScreen();
        }

        [When(@"set the url for add-car-rental-page")]
        public void WhenSetTheUrlForAdd_Car_Rental_Page()
        {
            driver.Url = "http://localhost:59491/add-car-rental-page";
        }

        [Then(@"the photo for add-car-rental-page is displayed")]
        public void ThenThePhotoForAdd_Car_Rental_PageIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[1]/table/tbody/tr/td[1]/div/img"));
            Assert.IsTrue(element != null);
            driver.Close();
        }



        [Then(@"'(.*)' label is displeyed")]
        public void ThenLabelIsDispleyed(string label)
        {
          IWebElement element=driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[1]/table/thead/tr/th[1]"));
           Assert.AreEqual(label, element.Text);
            driver.Close();
        }

        [Then(@"'(.*)' label is displayed for registration number")]
        public void ThenLabelIsDisplayedForRegistrationNumber(string p0)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[1]/table/thead/tr/th[2]"));
            Assert.AreEqual(p0, element.Text);
            driver.Close();
        }

        [Then(@"'(.*)' label is displayed for number of doors")]
        public void ThenLabelIsDisplayedForNumberOfDoors(string p1)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[1]/table/thead/tr/th[4]"));
            Assert.AreEqual(p1, element.Text);
            driver.Close();
        }

        [Then(@"the button previous is working")]
        public void ThenTheButtonIsWorking()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[3]/app-calendar/div[1]/div[1]/div/div[1]"));
            Assert.IsTrue( element.Enabled);
            driver.Close();
        }

        [Then(@"the below tabs are available")]
        public void ThenTheBelowTabsAreAvailable(Table table)
        {

            foreach (var row in table.Rows )
            {
                IWebElement element;
                switch (row["tabs"].ToLower())
                {
                    case "month":
                        element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[3]/app-calendar/div[1]/div[3]/div/div[1]"));
                        break;

                    case "week":
                        element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[3]/app-calendar/div[1]/div[3]/div/div[2]"));
                        break;

                    case "day":
                        element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[3]/app-calendar/div[1]/div[3]/div/div[3]"));
                        break;

                    default:

                        Assert.Fail("unexpected tab was received " + row["tabs"]);
                        element = null;
                        break;

                }
                Assert.AreEqual(row["tabs"], element.Text);
            }
            driver.Close();
        }


        [Then(@"first name checkbox is enabled")]
        public void ThenFirstNameCheckboxIsEnabled()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"userFirstName\"]"));
            Assert.IsTrue(element.Enabled);
        }

        [Then(@"and label is '(.*)'")]
        public void ThenAndLabelIs(string p5)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-add-car-rental-page/div[2]/label[1]"));
            Assert.AreEqual(p5.Trim(), element.Text.Trim());
            driver.Close();
        }


    }
}
