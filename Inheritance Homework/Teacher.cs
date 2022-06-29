using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Homework
{
    class Teacher:Person

    {
        private decimal salary;


        public Teacher(string name, string surname, int num): base(name)
        {
            //name = "Riquelme";
            //Console.WriteLine(name);
        }
    }
}
