using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Homework
{
    class Login
    {
        private string login;
        private string password;
        public string MyPassword 
        
        
        {
            get
            {
                if (password == "12345")
                {
                    Console.WriteLine("Correct");

                }
                return password;

            }





            set
            {
                if (value != "12345")
                {
                    Console.WriteLine("Incorrect");
                    return;
                }

                password = value;
            }
        
        
        }
        public string MyLogin 
        {
            get
            {
                

                if(login == "cavid@code.edu.az")
                {
                    Console.WriteLine("Login succesfull");
                    
                }
                return login;
            }






            set
            {
                if(value != "cavid@code.edu.az")
                {
                    Console.WriteLine("Incorrect");
                    return;
                }

                login = value;
               
                
                


            }
        
        
        }

    }
}
