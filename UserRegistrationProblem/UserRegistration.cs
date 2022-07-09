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
        // Checking the Password that should have min 8 characters with atleast 1 UpperCase,1 Numeric Number & 1 SpecialCharacter
        public static void CheckUserPassword()
        {
            Console.WriteLine("Enter your Password- ");
            string Password = Console.ReadLine();
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$";
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
