using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Homework
{
    class Test
    {
        public string name;
        public string password;

       internal static void Homework(string name, string password)
        {
            if (name == "cavid@code.edu.az" && password == "12345")
            {
                Console.WriteLine("Login succesfull");

            }
            else
            {
                Console.WriteLine("Please retype your login or password");
            }

        //static void MyLogin(string name, string password)
        //{
        //    if (name == "cavid@code.edu.az" && password == "12345")
        //    {
        //        Console.WriteLine("Login succesfull");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Please retype your login or password");
        //    }
        }


    }
}
