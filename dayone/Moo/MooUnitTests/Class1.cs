using System;
using Xunit;

namespace MooUnitTests
{
    public class Class1
    {
	[Fact]
        public void PassingTest()
        {
            Assert.Equal(1, Add(4, 4));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(2, Add(4, 4));
        }
		
	[Fact]
        public void ExceptionTest()
        {
            Assert.Equal(0, Add(2, 0));
        }
		
		static public int Add(int x, int y)
        {
 		int TotalValue = 0;             

            try
            {
                TotalValue =  x / y;  

		//FB Let's discuss
		//throw new DivideByZeroException(); 				

	    
            }catch (DivideByZeroException z)
            {
                Console.WriteLine("test error Add :" + z.ToString());
            } catch (Exception e)
            {
                Console.WriteLine("test error value " + e.ToString());
                throw (e);
            }

            
            return TotalValue;
        }
  
        static void Main(string[] args)
        {
			Class1 test = new Class1();
			test.ExceptionTest();
			test.PassingTest();
			test.FailingTest();
			
        }
		
    }
}
