using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace User_Registration
{
    /// <summary>
    /// Program to showcase the use of Regex Validation
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

            User_Info user = new User_Info();

            //User prompt for first name
            Console.WriteLine("Enter the first name :");
            string first_Name = Console.ReadLine();

            //Validation anonymous method for First Name field
            Func<string, bool> ValidationFirstName = (first_Name) =>
             {
                 //Regex patter to accept first letter Capital and greater than 3 char
                 Regex regex = new Regex("^[A-Z]{1}[a-z]{2,}");
                 Match match = regex.Match(first_Name);
                 return match.Success;
             };

            //Check validation
            while (ValidationFirstName(first_Name) == false)
            {
                Console.WriteLine("Enter First Name Again..");
                first_Name = Console.ReadLine();
            }

            user.First_name = first_Name;

            //user prompt for last name
            Console.WriteLine("Enter the last name :");
            string last_Name = Console.ReadLine();

            //Validation anonymous method for Last Name field
            Func<string, bool> ValidationLastName = (last_Name) =>
            {
                //Regex patter to accept first letter Capital and greater than 3 char
                Regex regex = new Regex("^[A-Z]{1}[a-z]{2,}");
                Match match = regex.Match(last_Name);
                return match.Success;
            };

            //Check validation
            while (ValidationLastName(last_Name) == false)
            {
                Console.WriteLine("Enter last Name Again..");
                last_Name = Console.ReadLine();
            }
            user.Last_name = last_Name;

            //user prompt for Email ID
            Console.WriteLine("Enter the email ID :");
            string email_ID = Console.ReadLine();

            //Validation anonymous method for Email field
            Func<string, bool> ValidationEmailID = (email_ID) =>
            {
                //Regex pattern for email 
                Regex regex = new Regex(@"^[^\.][a-zA-Z_\-0-9]*[\.]*[a-zA-Z_\-0-9]+@[a-z0-9]+[\.][a-z]{2,4}([\.][a-z]{2,3})?$");
                Match match = regex.Match(email_ID);
                return match.Success;
            };

            //Check validation
            while (ValidationEmailID(email_ID) == false)
            {
                Console.WriteLine("Enter email id Again..");
                email_ID = Console.ReadLine();
            }

            user.email_Id = email_ID;

            //user prompt for phone number
            Console.WriteLine("Enter the phone number :");
            string phone_Num = Console.ReadLine();

            //Validation anonymous method for Phone Number field
            Func<string, bool> ValidationPhoneNum = (phone_Num) =>
            {
                //Regex patter accepting + (optional) with country code (91), spacing(optional) and 10 digit phone number
                Regex regex = new Regex("^[+]*[0-9]{2}[\\s][0-9]{10}");
                Match match = regex.Match(phone_Num);
                return match.Success;
            };

            //Check validation 
            while (ValidationPhoneNum(phone_Num) == false)
            {
                Console.WriteLine("Enter Phone Number Again..");
                phone_Num = Console.ReadLine();
            }

            user.phone_Number = phone_Num;

            //User prompt for password
            Console.WriteLine("Enter the password :");
            string password = Console.ReadLine();



            //Validation anonymous method for Password field
            Func<string, bool> ValidationPassword = (password) =>
            {
                //Regex pattern accepting min 8 characters,Should have Captial letter and numeric with atleast one special character
                String pattern = "(?=^.{8,}$)";
                String pattern_UpperCase = "[A-Z]+";
                String pattern_Numeric = "[0-9]+";
                String pattern_SpecialCharacter = "[!@#$%^&*()]{1}";

                Regex regex_MinChar = new Regex(pattern);
                Regex regex_UpperCase = new Regex(pattern_UpperCase);
                Regex regex_Numeric = new Regex(pattern_Numeric);
                Regex regex_SpecialCharacter = new Regex(pattern_SpecialCharacter);

                //Regex regex = new Regex("(?=^.{8,}$)(?=.*[A-Z]+)(?=.*[0-9]+) (?=.*[!@#$%^&*()]{1})");
                Match match = regex_MinChar.Match(password);
                Match match_UpperCase = regex_UpperCase.Match(password);
                Match match_Numeric = regex_Numeric.Match(password);
                Match match_SpecialCharacter = regex_SpecialCharacter.Match(password);

                
                return match.Success && match_UpperCase.Success && match_Numeric.Success && match_SpecialCharacter.Success;
            };

            //check validation
            while (ValidationPassword(password) == false)
            {
                Console.WriteLine("Enter Password Again..");
                password = Console.ReadLine();
            }

            user.password = password;

            //Print output
            Console.WriteLine("Entered Details are: \n");
            Console.WriteLine(user.First_name);
            Console.WriteLine(user.Last_name);
            Console.WriteLine(user.phone_Number);
            Console.WriteLine(user.email_Id);
            Console.WriteLine(user.password);


        }
    }
}
