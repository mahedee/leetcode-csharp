using System;
using System.Collections.Generic;

namespace MinimumDepth
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
        public int MinDepth(TreeNode root)
        {
            // Corner case
            if (root == null) return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int level = 0;
            while(queue.Count > 0)
            {
                level++;

                // no of nodes in each level
                int nodesOfLevel = queue.Count;

                for (int i = 1; i <= nodesOfLevel; i++)
                {
                    // if any node which doesn't have left and right node is the leaf
                    if (queue.Peek().left == null && queue.Peek().right == null) return level;

                    if(queue.Peek().left != null)
                        queue.Enqueue(queue.Peek().left);

                    if (queue.Peek().right != null)
                        queue.Enqueue(queue.Peek().right);

                    // Remove an element
                    queue.Dequeue();
                }
            }
            return level;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);

            root.left = new TreeNode(9);
           // root.left.left = new TreeNode(1);
           // root.left.left.left = new TreeNode(2);

            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Solution solution = new Solution();
            Console.WriteLine(solution.MinDepth(root));

            Console.ReadKey();
        }
    }
}
