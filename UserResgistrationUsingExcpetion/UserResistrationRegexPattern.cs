using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResgistrationUsingExcpetion
{
    public class UserResistrationRegexPattern
    {
        public static string RegexFirstName = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string RegexLastName = "^[a-zA-Z]{1}[a-z]{2,}";
        public static string RegexEmailId = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";
        public static string RegexPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public static string RegexPassword1 = "^[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword2 = "^(?=.*[A-Z])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword3 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword4 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#$&])[A-Za-z0-9.@!#$&]{8,}$";

        public bool ValidateFirstName(string firstName)
        {
            if(!Regex.IsMatch(firstName, RegexFirstName))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Invalid First Name");
            }
            return true;
        }
        public bool ValidateLastName(string LastName)
        {
            if (!Regex.IsMatch(LastName, RegexLastName))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Invalid Last Name");
            }
            return true;
        }

        public bool ValidateEmaild(string Emailid)
        {
            if (!Regex.IsMatch(Emailid, RegexEmailId))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Invalid EmailID");
            }
            return true;
        }

        public bool ValidatePhoneNumber(string PhoneNumber)
        {
            if (!Regex.IsMatch(PhoneNumber, RegexPhoneNumber))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Invalid Phone Number");
            }
            return true;
        }

        public bool ValidatePassword(string Password)
        {
            if (!Regex.IsMatch(Password, RegexPassword1))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Password Should Have Minimum 8 Charactres!");
            }
            return true;
        }

        public bool ValidatePassword2(string Password2)
        {
            if (!Regex.IsMatch(Password2, RegexPassword2))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Password Should Have UpperCase Letter");
            }
            return true;
        }

        public bool ValidatePassword3(string Password3)
        {
            if (!Regex.IsMatch(Password3, RegexPassword3))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Password Should Have 1 Numeric Number");
            }
            return true;
        }

        public bool ValidatePassword4(string Password4)
        {
            if (!Regex.IsMatch(Password4, RegexPassword4))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Password Should Have 1 Special Character");
            }
            return true;
        }
    }
}
