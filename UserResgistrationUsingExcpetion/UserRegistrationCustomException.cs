using System;
using System.Collections.Generic;
using System.Text;

namespace UserResgistrationUsingExcpetion
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_ENTER,
        }

        public ExceptionType type;
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
