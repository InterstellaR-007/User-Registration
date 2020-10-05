using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String user_Password = "";
            String pattern = "[a-zA-Z]{8,}";
            Regex regex = new Regex(pattern);
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the password : ");
                user_Password = Console.ReadLine();
                Match match = regex.Match(user_Password);
                if (match.Success)
                {
                    Console.WriteLine("Valid password :" + user_Password);
                    exit_Program = true;

                }
                else
                    Console.WriteLine("Invalid entered password. Try Again:" + user_Password);
            }
        }
    }
}