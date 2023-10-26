using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerfectSquare;

namespace PerfectSquareTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, new Solution().IsPerfectSquare(808201));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, new Solution().IsPerfectSquare(4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, new Solution().IsPerfectSquare(16));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, new Solution().IsPerfectSquare(14));
        }
    }
}
