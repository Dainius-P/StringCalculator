using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorUnitTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void TestAddMethodNumber()
        {
            int numb = Calculator.Add("123");
            Assert.AreEqual(numb, 123);
        }

        public void TestAddMethodNumberEmpty()
        {
            int numb = Calculator.Add("");
            Assert.AreEqual(numb, 0);
        }

        public void TestAddMethodMultipleNumbers()
        {
            int numb = Calculator.Add("1,2,3");
            Assert.AreEqual(numb, 6);
        }
    }
}
