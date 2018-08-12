using System;
using Xunit;
using Application;

namespace TestProject
{
    public class UnitTest1
    {
        IGreenhouse greenhouse = new Greenhouse();

        [Fact]
        public void Test1()
        {
            // ARRANGE
            int correctSquareMeters = 16;

            // ACT
            int calculatedSquareMeters = greenhouse.SquareMeters();

            // ASSERT
            Assert.Equal(correctSquareMeters, calculatedSquareMeters);
        }
    }
}
