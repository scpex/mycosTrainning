using System;
using Xunit;

namespace Mycos.Training2.CSharp.John 
{
    public class Strings_v2 
    {

        public void DoSomethng(int rt, int ew)
        {

        }

        
        [Fact]
        public void FailingTest()
        {
            String stringOne = "mycos";
            String stringTwo = "technologies";

            Assert.Equal(14, GetCombinedLength(stringOne, stringTwo));
        }

        int GetCombinedLength(string x, string y)
        {
            return (x + y).Length;
        }

        [Theory]
        [InlineData("Coding is cool.")]
        [InlineData("Nerds Rule the World... Secretly")]
        [InlineData(String.Empty)]
        public void MyFirstTheory(String testString)
        {
            Assert.IsType(Type.GetType("System.Int32"), 1);
            Assert.IsType(Type.GetType("System.String"), testString);
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        bool DoSomethingRad()
        {
            return true;
        }

    }
}
