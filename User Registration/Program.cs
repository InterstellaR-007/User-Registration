using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String user_Password = "";
            String pattern = "[a-zA-Z0-9]{8,}";
            String pattern_UpperCase = "[A-Z]+";
            String pattern_Numeric = "[0-9]+";
            Regex regex = new Regex(pattern);
            Regex regex_UpperCase = new Regex(pattern_UpperCase);
            Regex regex_Numeric = new Regex(pattern_Numeric);
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the password : ");
                user_Password = Console.ReadLine();
                Match match = regex.Match(user_Password);
                Match match_UpperCase = regex_UpperCase.Match(user_Password);
                Match match_Numeric = regex_Numeric.Match(user_Password);

                if (match.Success && match_UpperCase.Success && match_Numeric.Success)
                {
                    Console.WriteLine("Valid password :" + user_Password);
                    exit_Program = true;

                }
                else
                    Console.WriteLine("Invalid entered password. Try Again:" + match.Success + match_UpperCase.Success + match_Numeric.Success);
            }
        }
    }
}