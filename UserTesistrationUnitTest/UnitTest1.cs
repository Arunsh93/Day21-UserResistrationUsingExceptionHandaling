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

        [TestMethod]
        public void GivenLastName_ThrowInvalidNameException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidateLastName("123hosur");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmailId_ThrowInvalidEmailidException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidateEmaild("abc.xyz@bl.co.in");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Invalid EmailID", ex.Message);
            }
        }

        [TestMethod]
        public void GivenPhoneNumber_ThrowInvalidPhoneNumberException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidatePhoneNumber("91 9620692457");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Invalid Phone Number", ex.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_ThrowInvalidPasswordException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidatePassword("Arun@123");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Password Should Have Minimum 8 Charactres!", ex.Message);
            }
        }

        [TestMethod]
        public void GivenPasswordUpperCase_ThrowInvalidPasswordException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidatePassword2("Arun@123");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Password Should Have UpperCase Letter", ex.Message);
            }
        }

        [TestMethod]
        public void GivenPasswordhaveNumericNumber_ThrowInvalidPasswordException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidatePassword3("ABC123@!");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Password Should Have 1 Numeric Number", ex.Message);
            }
        }
        [TestMethod]
        public void GivenPasswordhaveSpecialCharacter_ThrowInvalidPasswordException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidatePassword4("Arunsh@123");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Password Should Have 1 Special Character", ex.Message);
            }
        }

        [TestMethod]
        public void GivenSampleEmailId_ThrowInvalidEmailidException()
        {
            try
            {
                //Arrange
                bool Expected = true;

                //Action
                bool Actual = userMatch.ValidateSampleEmailId("null");

                //Assert
                Assert.AreEqual(Expected, Actual);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Invalid EmailId", ex.Message);
            }
        }
    }
}
