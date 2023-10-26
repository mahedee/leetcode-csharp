using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestForSolution2
    {
        [TestMethod]
        public void TestMethod121()
        {
            Assert.AreEqual(true, Program.IsPalindrome(121));
        }

        [TestMethod]
        public void TestMethod121Minus()
        {
            Assert.AreEqual(false, Program.IsPalindrome(-121));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(false, Program.IsPalindrome(10));
        }

        [TestMethod]
        public void TestMethod123321()
        {
            Assert.AreEqual(true, Program.IsPalindrome(123321));
        }


        [TestMethod]
        public void TestMethod323()
        {
            Assert.AreEqual(true, Program.IsPalindrome(323));
        }

        [TestMethod]
        public void TestMethod123123()
        {
            Assert.AreEqual(false, Program.IsPalindrome(123123));
        }


        [TestMethod]
        public void TestMethodZero()
        {
            Assert.AreEqual(true, Program.IsPalindrome(0));
        }
    }
}
