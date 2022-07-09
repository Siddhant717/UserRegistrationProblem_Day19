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
        public static void CheckLastName()
        {
            Console.WriteLine("Enter your Last Name- ");
            string lastname = Console.ReadLine();
            string lastnamepattern = @"^[A-Z]{1}[a-z]{2,}$";
            Regex lastnameregex = new Regex(lastnamepattern);
           
            var Result = lastnameregex.IsMatch(lastname);
            if(Result==true)
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Last Name");
            }


        }
    }
}
