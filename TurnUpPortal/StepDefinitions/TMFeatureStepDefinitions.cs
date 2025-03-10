using NUnit.Framework;
using TurnUpPortal.Pages;

namespace TurnUpPortal.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : BaseTest
    {
        [Given("user logged in to the Turnup Portal successfully with valid username {string} and password {string}")]
        public void GivenUserLoggedInToTheTurnupPortalSuccessfullyWithValidUsernameAndPassword(string username, string password)
        {
            //Login page object initialization and definition
            loginPage.EnterUserNamePassword(username, password);
            loginPage.ClickLoginButton();
        }

        [Given("navigate to time and materials page")]
        public void GivenNavigateToTimeAndMaterialsPage()
        {
            //Home page object initialization and definition
             homePage.GoToTimeAndMaterials();
        }

        [When("creating a new time and material record")]
        public void WhenCreatingANewTimeAndMaterialRecord()
        {
            //Time and Materials page object initialization and definition
            timeAndMaterialPage.CreateRecord("A_001", "Create", "20");
        }

        [Then("the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCodeTxt = timeAndMaterialPage.GetNewCode();
            string newDescriptionTxt = timeAndMaterialPage.GetNewDescription();
            string newPriceTxt = timeAndMaterialPage.GetNewPrice();

            Assert.That(newCodeTxt == "A_001", "Actual and Expected don't match!");
            Assert.That(newDescriptionTxt == "Create", "Actual and expected don't match!");
            Assert.That(newPriceTxt == "$20.00", "Actual and Expected don't match!");
        }

        [When("editing the {string} and {string} textbox")]
        public void WhenEditingTheAndTextbox(string code, string description)
        {
            timeAndMaterialPage.ClickGoToLastPageButton();
            timeAndMaterialPage.Edit(code, description);
        }

        [Then("the record should have the updated {string} and {string}")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string code, string description)
        {
            timeAndMaterialPage.ClickGoToLastPageButton();
            string updatedCode = timeAndMaterialPage.GetEditedCode();
            string updatedDescription = timeAndMaterialPage.GetEditedDescription();

            Assert.That(updatedCode == code, "Actual and Expected don't match!");
            Assert.That(updatedDescription == description, "Actual and Expected don't match!");
            Console.WriteLine("Record successfully updated!");
        }
        [When("deleting the last record")]
        public void WhenDeletingTheLastRecord()
        {
            timeAndMaterialPage.Delete();
        }

        [Then("the record should be deleted")]
        public void ThenTheRecordShouldBeDeleted()
        {
            timeAndMaterialPage.ClickGoToLastPageButton();
            string lastCodeTxt = timeAndMaterialPage.GetLastCode();
            string lastDescriptionTxt = timeAndMaterialPage.GetLastDescription();
            Assert.That(lastCodeTxt==)

           
        }

    }
}
