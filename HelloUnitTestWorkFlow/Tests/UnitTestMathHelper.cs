using HelloUnitTestWorkFlow;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestMathHelper
    {
        [Fact]
        public void TestSummation()
        {
            Assert.Equal(15, MathHelper.Sum(10, 5));
        }

        [Fact]
        public void TestSubtraction()
        {
            Assert.Equal(3, MathHelper.Subtract(10, 7));
        }
    }
}
