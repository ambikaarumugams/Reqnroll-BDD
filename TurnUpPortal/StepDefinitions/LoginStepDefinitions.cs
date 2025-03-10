using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal.Pages;

[Binding]
public class LoginStepDefinitions
{
    private  IWebDriver driver;
    private  LoginPage loginPage;

    [Given("User launch the Chrome browser")]
    public void GivenUserLaunchTheChromeBrowser()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
    }

    [When("User opens the url {string}")]
    public void WhenUserOpensTheUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
    }

    [When("Enter the valid username {string} and password {string}")]
    public void WhenEnterTheValidUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUserNamePassword(username, password);
    }

    [When("Click the Login button")]
    public void WhenClickTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }


    [Then("User should be logged in successfully")]
    public void ThenUserShouldBeLoggedInSuccessfully()
    {
        string successfulMsg = loginPage.GetLoginText();
        Assert.That(successfulMsg == "Hello hari!", "Actual and expected don't match");
    }
}