using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components;

//I .Net Core, brug MSTest Test Project, ikke xUnit Test
namespace ComponentsTest
{
    [TestClass]
    public class ComponentsTest
    {
        [TestMethod]
        public void TestGramsToOunces()
        {
            double grams = 15.0;
            var ounces = Converter.ToOunces(grams);
            Assert.AreEqual(0.52910942924, ounces, 0.0001);
        }

        [TestMethod]
        public void TestOuncesToGrams()
        {
            double ounces = 100.0;
            var grams = Converter.ToGrams(ounces);
            Assert.AreEqual(2834.952, grams, 0.0001);
        }
    }
}
