using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResgistrationUsingExcpetion
{
    public class UserResistrationRegexPattern
    {
        public string RegexPattern = "^[A-Z]{1}[a-zA-Z]{2,}";

        public bool ValidateFirstName(string firstName)
        {
            if(!Regex.IsMatch(firstName, RegexPattern))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_ENTER, "Invalid First Name");
            }
            return true;
        }      
    }
}
