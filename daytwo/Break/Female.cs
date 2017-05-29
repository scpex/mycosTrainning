using System;
using System.Collections.Generic;
using System.Text;

namespace Break
{
    public class Female : Ihumen
    {
        private String name;
        private double height,weight,BMI ;
        public Female(String _name)
        {
            this.name = _name;
        }
        
       public void talk()
       {
            Console.WriteLine("My name is " + this.name + " I am Female");
       }
       public double CalculateBMI() {
      Console.Write("\nEnter your height(m)... ");
      height = Double.Parse(Console.ReadLine());
            Console.Write("\nEnter your weight(kg)... ");
      weight = Double.Parse(Console.ReadLine());
      BMI = this.weight / this.height ;
      Console.Write("\nBMI of " + this.name + " is : " + BMI );
      return BMI; 
            }
   
    }
}
