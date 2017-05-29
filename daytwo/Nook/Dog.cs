using System;
using System.Collections.Generic;
using System.Text;

namespace Nook
{
    public class Dog : Ianimal
    {

        private String name;
        public Dog(String _name)
        {
            this.name = _name;
        }
        
       public void say()
       {
            Console.WriteLine("Bog Bog !!! " + this.name);
       }
       public String timeToSleep() { return "00:00"; }
       public String timeToWakeUp() { return "06:00"; }
    }
}
