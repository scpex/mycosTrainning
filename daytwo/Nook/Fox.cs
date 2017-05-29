using System;
using System.Collections.Generic;
using System.Text;

namespace Nook
{
    public class Fox : Ianimal
    {
        private String saying;

        public Fox(String _saying)
        {
            this.saying = _saying;
        }
        public void say()
        {
            Console.WriteLine("What does the fox say : " + this.saying);
        }
        public String timeToSleep() { return "7:00"; }
        public String timeToWakeUp() { return "17:00"; }
    }
}
