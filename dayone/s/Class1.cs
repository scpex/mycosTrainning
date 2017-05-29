using System;
using Xunit;

namespace s

{
	public class Class1
	{
		[Fact]
		public void PassingTest()
		{
			Assert.Equal(10, Add(5,5));
		}
		
		[Fact]
		public void FailingTest()
		{
			Assert.Equal(12, Add(5,5));
		}
		
		//add Exception Tester
		[Fact]
		public void ExceptionTester()
		{
			Add(2 ,Add(1, '1'));
		}
		
		int Add(int a, int b)
		{            
            int addresult=0;
			try
            {
				Console.WriteLine("No String");  
				Console.WriteLine(b.GetType());  
                addresult =  a + b;      
            }
            catch (Exception e)
            {
                Console.WriteLine("Error string type" + e.ToString());
                throw (e);
            }
			return addresult;
		}
		
		[Theory]
		[InlineData(3)]
		[InlineData(5)]
		[InlineData(6)]
		public void MyFirstTheory(int value)
		{
			Assert.True(Is0dd(value));
		}
		
		bool Is0dd(int value)
		{
			return value % 2 == 1;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Test Again");
			Add(5, 5);
			Console.ReadLine();
		}
	}
}
