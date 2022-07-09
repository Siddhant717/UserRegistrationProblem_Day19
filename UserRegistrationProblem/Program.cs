using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password should have minimum 8 characters and atleast 1 UpperCase -");
            UserRegistration.Check_Password_Atleast_1_UpperCase();
        }
    }
}
