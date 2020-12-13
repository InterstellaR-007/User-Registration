using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace User_Registration
{
    class AnnotationTest
    {

        public static void Display()
        {
            Console.WriteLine("Welcome to User Registration");
            User_Info obj = new User_Info();
            obj.First_name = "Anuj";
            obj.Last_name = "Sharma";
            obj.phone_Number = "91 9450058703";
            obj.password = "Anuj@1234";
            obj.email_Id = "anuj@gmail.com";
        }


    }
}
