using System;
using System.Collections.Generic;

namespace MaximumDepth
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
        public int MaxDepth(TreeNode root)
        {
            // Corner case
            if (root == null) return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            // initially put root in queue
            queue.Enqueue(root);

            // to count tree level
            int level = 0;

            while(queue.Count > 0)
            {
                level++;

                // no of nodes in each level
                int nodesInLevel = queue.Count;
                for(int i = 1; i <= nodesInLevel; i++)
                {
                    // queue.peek() return the front object without removing
                    if (queue.Peek().left != null)
                        queue.Enqueue(queue.Peek().left);

                    if (queue.Peek().right != null)
                        queue.Enqueue(queue.Peek().right);

                    // dequeue the object
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

            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Console.WriteLine(new Solution().MaxDepth(root));
            Console.ReadKey();
        }
    }
}
