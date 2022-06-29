using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Homework
{
    class Car
    {
        public string brand;
        private int horsePower;
        public int HorsePower 
        {
            get
            {
                if (horsePower < 100)
                {
                    Console.WriteLine("Can't drive");
                    return -1;
                }
                return horsePower;
                    


            }











            set
            {
                horsePower = value;
            }
        
        
        
        }



    }
}
