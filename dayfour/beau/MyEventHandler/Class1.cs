using System;

namespace MyEventHandler
{
  public delegate void EventHandler();

  class Program
    {
        
        static void Addition()
        {
			Console.WriteLine("Addition of 5 and 10 is : {0}", 5 + 10);
        }
        static void Subtraction()
        {
			Console.WriteLine("Subtraction of 5 and 10 is : {0}", 5 - 10);
        }
		
		public static event EventHandler OnShowResult;
	
        static void Main(string[] args)
        {
			OnShowResult += new EventHandler(Addition);
			OnShowResult += new EventHandler(Subtraction);
       
			Console.ReadLine();
        }
    }
}
