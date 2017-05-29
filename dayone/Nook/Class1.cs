using System;
using Xunit;


//FB: I might add a line here for readability
namespace NookUnitTest
{
    public class Class1
    {
     
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

	//FB: Why are all the other functions UpperCase and this is lowerCase?
        [Fact]
        public void exceptionTest()
        {
	    //FB: Interesting... char int value  => where is the assert? 
            Add(5, Add(2, '3'));
        }


        [Fact]
        public void ExceptionalParametersBombTest()
        {
	    //FB: Interesting... 
            Add(6, Add('2', '3'));
        }

       static public int Add(int x, int y)
        {
            int result = 0;             

            try
            {
                Console.WriteLine("x is: " + x);
                Console.WriteLine("y is: " + y);

                result =  x + y;      

                Console.WriteLine("The result was: " + result);

		        Console.WriteLine(System.Environment.StackTrace);
            }
            catch (Exception exception)
            {

                Console.WriteLine("The result was: " + result);
                Console.WriteLine("error is " + exception.ToString());

		//FB: What is the difference between throw exception and throw (exception)...
                throw (exception);
            }
            return result;
        }

        static void Main(string[] args)
        {
            
            Add(1, 2);
        }
    }
}
