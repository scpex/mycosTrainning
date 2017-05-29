using System;

namespace ExceptionTests
{
    public class FirstTest
    {
	  
	    	//FB: Nicely done.
		int Calculation(int x, int y)
		{
			try
            {
				var myval = 0;
				myval = (x * 2 / y - 10);
				return myval;
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error Message --> " + ex.ToString());
				throw ex;
			}
		}
		
		static void Main(string[] args)
		{
			FirstTest p = new FirstTest();
            Console.WriteLine("My Result is " + p.Calculation(20, 10));
		}	
    }
	
}
