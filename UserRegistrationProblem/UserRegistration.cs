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
        public static void CheckEmail()
        {
            Console.WriteLine("Enter your Email- ");
            string Email = Console.ReadLine();
            string emailpattern = @"^([A-Za-z]{3,}([.a-z]*)@[a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";
            Regex EmailRegex = new Regex(emailpattern);
           
            var Result = EmailRegex.IsMatch(Email);
            if(Result==true)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Email");
            }


        }
    }
}
