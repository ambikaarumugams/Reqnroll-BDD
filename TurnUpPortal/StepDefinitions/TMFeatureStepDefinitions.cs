using NUnit.Framework;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given("user logged in to the Turnup Portal successfully with valid username {string} and password {string}")]
        public void GivenUserLoggedInToTheTurnupPortalSuccessfullyWithValidUsernameAndPassword(string username, string password)
        {
            //Login page object initialization and definition
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserNamePassword(username, password);
            loginPage.ClickLoginButton();
        }

        [Given("navigate to time and materials page")]
        public void GivenNavigateToTimeAndMaterialsPage()
        {
            //Home page object initialization and definition
            HomePage homePage = new HomePage(driver);
            homePage.GoToTimeAndMaterials();
        }

        [When("creating a new time and material record")]
        public void WhenCreatingANewTimeAndMaterialRecord()
        {
            //Time and Materials page object initialization and definition
            TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage(driver);
            timeAndMaterialPage.CreateRecord("A_001", "Create", "20");
        }

        [Then("the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage(driver);
            string newCodeTxt = timeAndMaterialPage.GetNewCode();
            string newDescriptionTxt = timeAndMaterialPage.GetNewDescription();
            string newPriceTxt = timeAndMaterialPage.GetNewPrice();

            Assert.That(newCodeTxt == "A_001", "Actual and Expected don't match!");
            Assert.That(newDescriptionTxt == "Create", "Actual and expected don't match!");
            Assert.That(newPriceTxt == "$20.00", "Actual and Expected don't match!");
        }
    }
}
