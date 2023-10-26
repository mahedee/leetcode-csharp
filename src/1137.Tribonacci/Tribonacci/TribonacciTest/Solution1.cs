using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tribonacci;

namespace TribonacciTest
{
    [TestClass]
    public class Solution1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Program.Tribonacci(4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1389537, Program.Tribonacci(25));
        }
    }
}
