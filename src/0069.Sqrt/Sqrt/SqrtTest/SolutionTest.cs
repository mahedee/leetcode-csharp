using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sqrt;

namespace SqrtTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, new Solution().MySqrt(4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, new Solution().MySqrt(8));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(46339, new Solution().MySqrt(2147395599));
        }


    }
}
