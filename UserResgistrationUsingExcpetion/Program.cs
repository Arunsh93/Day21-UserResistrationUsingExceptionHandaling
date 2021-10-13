using System;

namespace UserResgistrationUsingExcpetion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to User Resistration Using Exception Handling*****");
            UserResistrationRegexPattern userResistration = new UserResistrationRegexPattern();
            Console.WriteLine("Enter FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("FirstName:" + userResistration.ValidateFirstName(firstName));
        }
    }
}
