using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestAutomation
{
    [Binding]
    public class TestHooks
    {
        [Before]
        public void CreateWebDriver(ScenarioContext context)
        {
            // Setup Chrome
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            context["WEB_DRIVER"] = driver;

            //
            driver.Url = $"https://dashboardtest.intellin.com/login";
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div/div[1]/div/div/div[2]/div/div[1]/div/input")).SendKeys("*********");
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div/div[1]/div/div/div[2]/div/div[3]/div/input")).SendKeys("*********");
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div/div[1]/div/div/div[2]/div/div[4]/button")).Click();
            
        }
      
        [After]
        public void CloseWebDriver(ScenarioContext context)
        {
          var driver = context["WEB_DRIVER"] as IWebDriver;
          driver.Quit();
        }
    }
}
