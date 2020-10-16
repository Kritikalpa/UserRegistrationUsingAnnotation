using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistrationusingAnnotation
{
    class UserAnnotationTest
    {
        public static void UserRegistratiion()
        {

            User user = new User();

            Console.WriteLine("\nEnter the first name");
            user.firstName = Console.ReadLine();

            Console.WriteLine("\nEnter the last name");
            user.lastName = Console.ReadLine();

            Console.WriteLine("\nEnter the Email");
            user.emailId = Console.ReadLine();

            Console.WriteLine("\nEnter the phone number");
            user.phoneNumber = Console.ReadLine();

            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.Write("\nMember Name : {0}{1}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.Write("Error Message :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
                Console.WriteLine("\nUser Registration Failed");
            }
            else
            {
                Console.WriteLine("First Name: " + user.firstName + "\n" + "Last Name: " + user.lastName + "\n" + "Email Id: " + user.emailId + "\n" + "Phone Number: " + user.phoneNumber);
                Console.WriteLine("User Registration successful");
            }
        }
    }
}
