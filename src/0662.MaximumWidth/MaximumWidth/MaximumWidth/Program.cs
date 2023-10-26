using System;
using System.Collections.Generic;

namespace MaximumWidth
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class NodeMarker
    {
        public TreeNode node;
        public int depth;
        public int position;
        public NodeMarker(TreeNode n, int d, int p)
        {
            node = n;
            depth = d;
            position = p;
        }
    }


    public class Solution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            // Corner case
            if (root == null) return 0;

            Queue<NodeMarker> queue = new Queue<NodeMarker>();

            // initially put root in queue
            queue.Enqueue(new NodeMarker(root,0,0));

            int curDepth = 0, left = 0, maxWidth = 0;

            while (queue.Count > 0)
            {
                NodeMarker aNode = queue.Dequeue();
                if(aNode.node != null)
                {
                    queue.Enqueue(new NodeMarker(aNode.node.left, aNode.depth + 1, aNode.position * 2));
                    queue.Enqueue(new NodeMarker(aNode.node.right, aNode.depth + 1, aNode.position * 2 + 1));

                    if (curDepth != aNode.depth)
                    {
                        curDepth = aNode.depth;
                        left = aNode.position;
                    }
                    maxWidth = Math.Max(maxWidth, aNode.position - left + 1);
                }
            }

            return maxWidth;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);

            root.left = new TreeNode(3);
            root.right = new TreeNode(2);

            root.left.left = new TreeNode(5);
            root.left.right = new TreeNode(3);

            //root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(9);

            Console.WriteLine(new Solution().WidthOfBinaryTree(root));

            root = new TreeNode(1);

            root.left = new TreeNode(3);
            //root.right = new TreeNode(2);

            root.left.left = new TreeNode(5);
            root.left.right = new TreeNode(3);

            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(9);

            Console.WriteLine(new Solution().WidthOfBinaryTree(root));

            //Console.WriteLine();
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
