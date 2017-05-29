using System;
using Xunit;

namespace BreakTest
{
    public class Class1
    {
        [Fact]
        public void PassedTest()
        {
            Assert.Equal(9, Add(3, 3));
        }

        [Fact]
        public void FailedTest()
        {
            Assert.Equal(8, Add(2, 2));
        }

        [Fact]
        public void ExceptionTest()
        {
            Add(10, Add('5',2));
        }

       static public int Add(int x, int y)
        {
            int multiplyResult = 0;             
            try
            {
		Console.WriteLine("I'm not really a string... ");  

		Console.WriteLine(x.GetType());  

                multiplyResult =  x * y;      
            }
            catch (Exception e)
            {
	
		//Where is the exception thrown?
                Console.WriteLine("Error with cannot mutiply string type" + e.ToString());
                throw (e);
            }
            return multiplyResult;
        }
        static void Main(string[] args)
        {
          Class1 xunit = new Class1();
			xunit.ExceptionTest();
			xunit.PassedTest();
			xunit.FailedTest();
        }
    }
}
