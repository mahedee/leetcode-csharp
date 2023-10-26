using LongestCommonPrefix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestCommonPrefixTest
{
    [TestClass]
    public class Solution3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("fl", VerticalScanning.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", VerticalScanning.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        }
    }
}
