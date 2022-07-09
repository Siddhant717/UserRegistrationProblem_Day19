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
        public static void CheckFirstName()
        {
            Console.WriteLine("Enter your First Name- ");
            string firstname = Console.ReadLine();
            string firstnamepattern = @"^[A-Z]{1}[a-z]{2,}$";
            Regex firstnameregex = new Regex(firstnamepattern);
           
            var Result = firstnameregex.IsMatch(firstname);
            if(Result==true)
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid First Name");
            }


        }
    }
}
