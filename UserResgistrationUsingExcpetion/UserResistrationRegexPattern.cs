using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResgistrationUsingExcpetion
{
    public class UserResistrationRegexPattern
    {
        public string RegexFirstName = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string RegexLastName = "^[a-zA-Z]{1}[a-z]{2,}";
        public static string RegexEmailId = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";

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
    }
}
