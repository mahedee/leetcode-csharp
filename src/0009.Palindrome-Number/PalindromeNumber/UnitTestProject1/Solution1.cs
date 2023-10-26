using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestForSolution1
    {
        [TestMethod]
        public void TestMethod121()
        {
            Assert.AreEqual(true, Program.IsPalindromeSolution1(121));
        }

        [TestMethod]
        public void TestMethod121Minus()
        {
            Assert.AreEqual(false, Program.IsPalindromeSolution1(-121));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(false, Program.IsPalindromeSolution1(10));
        }

        [TestMethod]
        public void TestMethod123321()
        {
            Assert.AreEqual(true, Program.IsPalindromeSolution1(123321));
        }


        [TestMethod]
        public void TestMethod323()
        {
            Assert.AreEqual(true, Program.IsPalindromeSolution1(323));
        }

        [TestMethod]
        public void TestMethod123123()
        {
            Assert.AreEqual(false, Program.IsPalindromeSolution1(123123));
        }

        [TestMethod]
        public void TestMethodZero()
        {
            Assert.AreEqual(true, Program.IsPalindromeSolution1(0));
        }
    }
}
