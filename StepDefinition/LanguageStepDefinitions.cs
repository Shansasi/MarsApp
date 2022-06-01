using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Mars.Pages;
using Mars.Utilities;
using TechTalk.SpecFlow;

namespace ProfileDetails
{
    [Binding]
    public class ProfileDetailsStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the Turnup portal successfully")]
        public void GivenILoggedIntoTheTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I adding '([^']*)', and level in the profile page and save it")]
        public void WhenIAddingAndLevelInTheProfilePageAndSaveIt(string language)
        {
            //Profile create page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfileDetails(driver, language);
        }

        [Then(@"then '([^']*)' and level should be saved successfully")]
        public void ThenThenAndLevelShouldBeSavedSuccessfully(string malayalam)
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newCreatedData = profilePageObj.GetCreatedData(driver);
            Assert.That(newCreatedData == "Basic", "language not created successfully");

        }


        [When(@"I editing '([^']*)' and level and save it")]
        public void WhenIEditingAndLevelSaveIt(string language)
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfileDetails(driver, language);
        }

        [Then(@"the edited '([^']*)' and level should be saved successfully")]
        public void ThenTheEditedAndLevelShouldBeSavedSuccessfully(string language)
        {
            ProfilePage profilePageObj = new ProfilePage();
            string neweditedData = profilePageObj.GetEditedData(driver);
            Assert.That(neweditedData == "Fluent", "language not updated successfully");
            // IWebElement editedData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(editedData.Text == "Fluent", "language not updated successfully");
        }


        [When(@"I  Removing language and save it")]
        public void WhenIRemovingLanguageAndSaveIt()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteProfileDetails(driver);
        }

        [Then(@"the language should be removed successfully")]
        public void ThenTheLanguageShouldBeRemovedSuccessfully()
        {

            ProfilePage profilePageObj = new ProfilePage();
            string newDeletedData = profilePageObj.GetDeletedData(driver);
            Assert.That(newDeletedData == "Fluent", "language removed successfully");
        }
    }
}
