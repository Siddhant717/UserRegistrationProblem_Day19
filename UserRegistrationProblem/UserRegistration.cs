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
       
        public static void CheckEmailSample()
        {
            Console.WriteLine("Enter Email- ");
            string Email = Console.ReadLine();
            string EmailPattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";
            Regex EmailPatternRegex = new Regex(EmailPattern);
           
            var Result = EmailPatternRegex.IsMatch(Email);
            if(Result==true)
            {
                Console.WriteLine("Email Sample is valid");
            }
            else
            {
                Console.WriteLine("Email Sample is not valid");
            }


        }
    }
}
