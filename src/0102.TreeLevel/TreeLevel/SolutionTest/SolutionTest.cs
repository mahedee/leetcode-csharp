using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TreeLevel;

namespace TreeLevelTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            Solution solution = new Solution();

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int> { 3 });
            expected.Add(new List<int> { 9, 10 });
            expected.Add(new List<int> { 15, 7 });
            CollectionAssert.Equals(expected, solution.LevelOrder(tree));


        }
    }
}
