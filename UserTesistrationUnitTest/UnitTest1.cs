using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserResgistrationUsingExcpetion;

namespace UserTesistrationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        UserResistrationRegexPattern userMatch = new UserResistrationRegexPattern();

        [TestMethod]
        public void GivenFirstName_ThrowInvalidNameException()
        {           
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidateFirstName("arun123");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
    }
}
