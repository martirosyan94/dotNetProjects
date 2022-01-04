using Interview;
using System;
using System.Reflection;
using Xunit;


namespace ReflactionXUnitTests
{
    public class ReflactionTest
    {
        [Fact]
        public void GetNumberOfMethods_Should_Return_3()
        {
            // ARRANGE
            var reflaction = new Reflaction();

            // ACT
            var result = reflaction.GetNumberOfMethods(typeof(Car).GetMethods(), "R");

            // ASSERT
            Assert.Equal(3, result);

        }
        [Fact]
        public void GetNumberOfMethods_Should_Throws_Exception()
        {
            // ARRANGE
            var reflaction = new Reflaction();

            // ASSERT
            Assert.Throws<Exception>(() => reflaction.GetNumberOfMethods(typeof(Car).GetMethods(), "RR"));
        }
    }
}
