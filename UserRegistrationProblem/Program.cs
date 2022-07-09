using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password should have minimum 8 characters with atleast 1 UpperCase,1 Numeric Number & 1 SpecialCharacter -");
            UserRegistration.CheckUserPassword();
        }
    }
}
