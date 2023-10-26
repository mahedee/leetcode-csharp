using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace TwoSumTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 2, 7, 11, 15 };
            int target = 9;
            int[] output = { 1, 2 };
            CollectionAssert.AreEqual(output, new Solution().TwoSum(input, target));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 1, 2, 3, 4, 4, 9, 56, 90 };
            int target = 8;
            int[] output = { 4, 5 };
            CollectionAssert.AreEqual(output, new Solution().TwoSum(input, target));
        }
    }
}
