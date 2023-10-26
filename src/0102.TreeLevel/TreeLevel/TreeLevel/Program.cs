using System;
using System.Collections.Generic;

namespace TreeLevel
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> treeLevel = new List<IList<int>>();

            // Corner case value
            if (root == null) return treeLevel;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            // Initially put root in queue
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                // Count how manay nodes in each level
                // Queue contains nodes in each leave
                int levelSize = queue.Count;

                List<int> nodeList = new List<int>();
                for (int i = 1; i <= levelSize; i++)
                {
                    // queue.Peek() returns ofbject at the beginning of the queue without removing it.
                    if (queue.Peek().left != null) queue.Enqueue(queue.Peek().left);
                    if (queue.Peek().right != null) queue.Enqueue(queue.Peek().right);

                    // remove the node from queue and add to the list
                    TreeNode node = queue.Dequeue();
                    nodeList.Add(node.val);
                }

                treeLevel.Add(nodeList);
            }
            return treeLevel;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            Solution solution = new Solution();
            solution.LevelOrder(tree);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
