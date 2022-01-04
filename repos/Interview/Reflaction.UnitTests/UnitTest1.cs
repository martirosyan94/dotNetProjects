using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview;

namespace Reflaction.UnitTests
{
    [TestClass]
    public class ReflactionTests
    {
        [TestMethod]
        public void GetNumberOfMethods_RAmmount_Returns3()
        {
            var reflaction = new Interview.Reflaction();
            var result = reflaction.GetNumberOfMethods(typeof(Car).GetMethods(), "3");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void SumLettersNumber_RAmmount_Returns22()
        {
            var reflaction = new Interview.Reflaction();
            var result = reflaction.SumLettersNumber(typeof(Car).GetMethods(), "R");
            Assert.AreEqual(result, 22);
        }
    }
}
