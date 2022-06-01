using NUnit.Framework;
using Mars.Utilities;
using System.Threading;

namespace Mars.Pages
{
    [TestFixture]
    public class ProfileDetails_Tests : CommonDriver
    {
        //Profile create page object initialization and definition
        ProfilePage profilePageObj = new ProfilePage();

        [Test, Order(1)]
        public void CreateProfileDetails_Test()
        {
            //Add language in Profile Details
            profilePageObj.CreateProfileDetails(driver,"dummy3");
        }

        [Test, Order(2)]
        public void EditProfileDetails_Test()
        {
            //edit
            profilePageObj.EditProfileDetails(driver,"dummy");
        }

        [Test, Order(3)]
        public void DeleteProfileDetails_Test()
        {
            //delete
            profilePageObj.DeleteProfileDetails(driver);
            
        }

        [OneTimeTearDown]        
        public void Cleanup()
        {
            CloseTestRun();
        }
    }
}