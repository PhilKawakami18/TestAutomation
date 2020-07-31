using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium;


namespace TestAutomation
{
    [Binding]
    public class AddNewItemSocialPrescribingSteps
    {
        private readonly IWebDriver driver;

        public AddNewItemSocialPrescribingSteps(ScenarioContext scenarioContext)
        {
            driver = scenarioContext["WEB_DRIVER"] as IWebDriver;
 

        }
        [Given(@"I navigate to Social Prescribing link")]
        public void GivenINavigateToSocialPrescribingLink()
        {
           //driver.FindElement(By.XPath("//a[contains(@href,'social-prescribing-items-list')]")).Click();
           //Navigating to Prescribing Item
           driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[1]/a[5]/li")).Click();
          
        }

        [When(@"I click on Create a new item, fill the form and save")]
            public void WhenIClickOnCreateANewItemFillTheFormAndSave()
            {
            //Click to create
            //driver.FindElement(By.XPath("//*[@id='root']//div/div[2]/div[2]/div/div[3]/a/button/span[1]/div")).Click();
            driver.FindElement(By.ClassName("MuiButton-label")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[2]/div")).SendKeys("Hello");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[3]/div/textarea")).SendKeys("Phil Description");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[4]/div/input")).SendKeys("phil@gmail.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[5]/div/input")).SendKeys("0777777777");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[6]/div/input")).SendKeys("www.phil.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div[7]/button")).Click();
        
        }

        [Then(@"the new item should be added to the list")]
            public void ThenTheNewItemShouldBeAddedToTheList()
            {
            //Validate element with name
            String check = driver.FindElement(By.XPath("//*[contains(text(),'Hello')]"));
            Assert.Equal("Hello", check);
            }
        }
    }

