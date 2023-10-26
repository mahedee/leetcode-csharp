using Intersection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntersectionTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            Solution solution = new Solution();
            CollectionAssert.AreEqual(new int[] { 4, 9 }, solution.Intersection(nums1, nums2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            Solution solution = new Solution();
            CollectionAssert.AreEqual(new int[] { 2 }, solution.Intersection(nums1, nums2));
        }
    }
}
