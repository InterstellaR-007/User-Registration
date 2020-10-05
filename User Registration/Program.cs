using System;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String first_Name = "";
            String pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the first name : ");
                first_Name = Console.ReadLine();
                Match match = regex.Match(first_Name);
                if (match.Success)
                {
                    Console.WriteLine("Valid Input :" + first_Name);
                    exit_Program = true;

                }
                else
                    Console.WriteLine("Invalid Input :" + first_Name);
            }
        }
    }
}
