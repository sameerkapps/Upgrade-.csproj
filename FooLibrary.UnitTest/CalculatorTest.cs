using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FooLibrary.UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_WithPositiveInput_ReturnsExpected()
        {
            Calculator calc = new Calculator();

            var result = calc.Add(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}
