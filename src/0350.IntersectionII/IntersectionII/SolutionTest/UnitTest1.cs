using IntersectionII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = { 1, 2, 2, 1 }, nums2 = { 2, 2 };
            //int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4 };
            Solution solution = new Solution();
            int[] output = solution.Intersect(nums1, nums2);

            CollectionAssert.AreEqual(new int[] { 2, 2 }, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4 };
            //int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4 };
            Solution solution = new Solution();
            int[] output = solution.Intersect(nums1, nums2);

            CollectionAssert.AreEqual(new int[] { 4, 9 }, output);
        }
    }
}
