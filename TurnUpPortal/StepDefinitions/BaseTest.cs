using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Pages;


namespace TurnUpPortal.StepDefinitions
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public LoginPage loginPage;
        public HomePage homePage;
        public TimeAndMaterialPage timeAndMaterialPage;


        [BeforeScenario]
        public void SetUpSteps()
        {
            //Open the chrome browser
            driver = new ChromeDriver();
            //Launch TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            timeAndMaterialPage = new TimeAndMaterialPage(driver);
        }


        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}