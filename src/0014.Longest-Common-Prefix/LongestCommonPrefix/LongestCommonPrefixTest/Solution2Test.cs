using LongestCommonPrefix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestCommonPrefixTest
{
    [TestClass]
    public class Solution2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("fl", HorizontalScanning.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", HorizontalScanning.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        }
    }
}
