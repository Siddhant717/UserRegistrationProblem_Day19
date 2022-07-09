using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        public static void Check_Password_Atleast_1_UpperCase()
        {
            Console.WriteLine("Enter your Password- ");
            string Password = Console.ReadLine();
            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";
            Regex PasswordPatternRegex = new Regex(PasswordPattern);
           
            var Result = PasswordPatternRegex.IsMatch(Password);
            if(Result==true)
            {
                Console.WriteLine("Entered Password is valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Password");
            }


        }
    }
}
