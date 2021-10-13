using System;

namespace UserResgistrationUsingExcpetion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to User Resistration Using Exception Handling*****");
            UserResistrationRegexPattern userResistration = new UserResistrationRegexPattern();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("First Name:" + userResistration.ValidateFirstName(firstName));

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Last Name:" + userResistration.ValidateLastName(lastName));
        }
    }
}
