using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String mob_Number = "";
            String pattern = "^[0-9]{2}[\\s]{1}[0-9]{10}$";
            Regex regex = new Regex(pattern);
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the mobile number : ");
                mob_Number = Console.ReadLine();
                Match match = regex.Match(mob_Number);
                if (match.Success)
                {
                    Console.WriteLine("Valid Mobile Number :" + mob_Number);
                    exit_Program = true;

                }
                else
                    Console.WriteLine("Invalid Mobile Number :" + mob_Number);
            }
        }
    }
}