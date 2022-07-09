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
        public static void CheckMobileNumber()
        {
            Console.WriteLine("Enter your Mobile Number- ");
            string MobileNumber = Console.ReadLine();
            string MobileNumberPattern = @"^[1-9]{2,}[' '][7-9]{1}[0-9]{9}$";
            Regex MobileNumberRegex = new Regex(MobileNumberPattern);
           
            var Result = MobileNumberRegex.IsMatch(MobileNumber);
            if(Result==true)
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Mobile Number");
            }


        }
    }
}
