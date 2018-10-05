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

        [TestMethod]
        public void TestLargeGramsToOunces()
        {
            double grams = 10147.0;
            var ounces = Converter.ToOunces(grams);
            Assert.AreEqual(357.9248919, ounces, 0.0001);
        }

        [TestMethod]
        public void TestLargeOuncesToGrams()
        {
            double ounces = 544077.0;
            var grams = Converter.ToGrams(ounces);
            Assert.AreEqual(15424321.793, grams, 0.0001);
        }

        [TestMethod]
        public void TestDecimalGramsToOunces()
        {
            double grams = 147.88;
            var ounces = Converter.ToOunces(grams);
            Assert.AreEqual(5.2163134931, ounces, 0.0001);
        }

        [TestMethod]
        public void TestDecimalOuncesToGrams()
        {
            double ounces = 89.42;
            var grams = Converter.ToGrams(ounces);
            Assert.AreEqual(2535.0140784, grams, 0.0001);
        }
    }
}
