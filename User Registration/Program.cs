using System;
using System.Text.RegularExpressions;


namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            String first_Name = "";
            String last_Name = "";
            String[] pattern = { "^[A-Z]{1}[a-z]{2,}", "^[A-Z]{1}[a-z]{2,}" };
            
            Boolean exit_Program = false;

            while (exit_Program != true)
            {


                Console.WriteLine("Enter the first name : ");
                first_Name = Console.ReadLine();
                Regex regex = new Regex(pattern[0]);
                Match match = regex.Match(first_Name);
                if (match.Success)
                {
                    Console.WriteLine("Valid Input :" + first_Name);
                    exit_Program = true;

                }
                else
                {
                    Console.WriteLine("Invalid Input :" + last_Name);
                    exit_Program = false;
                }
            }
            exit_Program = false;

            while (exit_Program != true)
            {

                Console.WriteLine("Enter the Last name : ");
                last_Name = Console.ReadLine();
                Regex regex = new Regex(pattern[1]);
                Match match = regex.Match(last_Name);
                if (match.Success)
                {
                    Console.WriteLine("Valid Input :" + last_Name);
                    exit_Program = true;

                }
                else
                {
                    Console.WriteLine("Invalid Input :" + last_Name);
                    exit_Program = false;
                }

            }
            }
        }
    }
