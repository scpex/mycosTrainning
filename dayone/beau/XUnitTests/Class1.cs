using Xunit;
using System;


namespace XUnitTests
{
    //FB: Maybe a better class name?
    public class Class1
    {

	//FB: Well done!
	[Fact]
        public void MyPassing()
        {
            Assert.Equal(15, Calculation(10, 7));
        }

        [Fact]
        public void MyFailing()
        {
            Assert.Equal(10, Calculation(20, 10));
        }

        int Calculation(int x, int y)
        {
            return (x - y) * 5;
        }
    }
}
