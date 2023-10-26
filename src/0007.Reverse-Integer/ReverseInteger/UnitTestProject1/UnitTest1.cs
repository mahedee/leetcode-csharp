using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInteger;

namespace UnitTestProject1
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(321,Program.Reverse(123));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-321, Program.Reverse(-123));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Program.Reverse(1534236469));
        }
    }
}
