using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password should have minimum 8 characters with atleast 1 UpperCase and 1 numeric number -");
            UserRegistration.CheckUserPassword();
        }
    }
}
