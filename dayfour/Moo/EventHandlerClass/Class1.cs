using System;

namespace EventHandlerClass
{
	public delegate int EventHandlerSumTotal(int a, int b);
	
    public class Class1
    {
		static void Main()
		{
			SumTotalClass a = new SumTotalClass();
			EventHandlerSumTotal eSumTotal = new EventHandlerSumTotal(a.SumTotal);    
			int Value = eSumTotal(5, 4);
			Console.WriteLine("Total = {0}", Value);
		}
    }
	public class SumTotalClass
	{
	  public int SumTotal(int a, int b)
	  { return a + b; }
	}
}
