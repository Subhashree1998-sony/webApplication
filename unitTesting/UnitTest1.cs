using businesslogic;
using System;
using Xunit;

namespace unitTesting
{
    public class UnitTest1
    {
        [Fact(DisplayName = "test if the summmation is correct")]
        public void Test1()
        {
            Bilogic1 bl = new Bilogic1();
            var result = bl.AddTwoNumber(2, 8);
            Assert.Equal(10, result);
        }
    }
}
