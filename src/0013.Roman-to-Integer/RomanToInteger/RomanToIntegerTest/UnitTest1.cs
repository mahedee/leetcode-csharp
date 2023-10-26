using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToInteger;

namespace RomanToIntegerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIII()
        {
            Assert.AreEqual(3, Program.RomanToInt("III"));
        }

        [TestMethod]
        public void TestMethodIV()
        {
            Assert.AreEqual(4, Program.RomanToInt("IV"));
        }

        [TestMethod]
        public void TestMethodIX()
        {
            Assert.AreEqual(9, Program.RomanToInt("IX"));
        }

        [TestMethod]
        public void TestMethodLVIII()
        {
            Assert.AreEqual(58, Program.RomanToInt("LVIII"));
        }

        [TestMethod]
        public void TestMethodMCMXCIV()
        {
            Assert.AreEqual(1994, Program.RomanToInt("MCMXCIV"));
        }
    }
}
