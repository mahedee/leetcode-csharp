using LongestCommonPrefix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestCommonPrefixTest
{
    [TestClass]
    public class Solution1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("fl", Program.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", Program.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        }

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    Assert.AreEqual("fl", new string[] { "flower", "flow", "flight" });
        //}
    }
}
