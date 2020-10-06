using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String email_ID = "";
            String pattern = @"^[a-zA-Z_\-0-9]+@[a-z0-9]+[\.][a-z]{2,4}([\.][a-z]{2,4})?$";
            
            Regex regex = new Regex(pattern);
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the email id : ");
                email_ID = Console.ReadLine();
                Match match = regex.Match(email_ID);
                if (match.Success)
                {
                    Console.WriteLine("Valid Input :" + email_ID);
                    exit_Program = true;

                }
                else
                    Console.WriteLine("Invalid Input :" + email_ID);
            }
        }
    }
}