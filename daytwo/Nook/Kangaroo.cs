using System;
using System.Collections.Generic;
using System.Text;

namespace Nook
{
    public class Kangaroo : Ianimal
    {
        

      
        public void say()
        {
            Console.WriteLine("RuRu Ru !!!");
        }

        public String timeToSleep()
        {
            return "20:00";
        }

        public String timeToWakeUp()
        {
            return "08:00";
        }

   
    }
}
