using System;

namespace LongestUnivaluePath
{
    //Definition for a binary tree node
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        int ans;
        public int LongestUnivaluePath(TreeNode root)
        {
            ans = 0;
            GetArrowLenght(root);
            return ans;
        }

        public int GetArrowLenght(TreeNode node)
        {
            if (node == null) return 0;

            int left = GetArrowLenght(node.left);
            int right = GetArrowLenght(node.right);

            int arrowLeft = 0, arrowRight = 0;

            if(node.left != null && node.left.val == node.val)
            {
                arrowLeft = arrowLeft + left + 1;
            }

            if(node.right !=null && node.right.val == node.val)
            {
                arrowRight = arrowRight + right + 1;
            }

            // to get the longest path(can turn round from left to right)
            ans = Math.Max(ans, arrowLeft + arrowRight);

            // to exclude branch
            return Math.Max(arrowLeft, arrowRight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(4);
            tree.right = new TreeNode(5);

            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(1);

            tree.right.right = new TreeNode(5);

            Console.WriteLine(new Solution().LongestUnivaluePath(tree));

            Console.ReadLine();
        }
    }
}
