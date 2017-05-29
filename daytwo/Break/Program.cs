using System;
using Break;
using System.Collections.Generic;

namespace Break
{
    class Program
    {   
       
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculate");
            Male John = new Male("John");  
            Female Jessica = new Female("Jessica");  
            John.talk();
            John.CalculateBMI();
            Jessica.talk();
            Jessica.CalculateBMI();        
        }
    }
}
