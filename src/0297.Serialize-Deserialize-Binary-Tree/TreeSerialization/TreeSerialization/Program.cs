using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSerialization
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) { val = x; }
    }

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            Encode(root, sb);
            return sb.Remove(sb.Length-1,1).ToString(); // Remove last comma
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            string[] strArray   = data.Split(',');
            Queue<string> dqueue = new Queue<string>(strArray);
            return Decode(dqueue);
        }

        public void Encode(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("null").Append(",");
            }
            else
            {
                sb.Append(root.val).Append(",");
                Encode(root.left, sb);
                Encode(root.right, sb);
            }

            //return sb;
        }


        public TreeNode Decode(Queue<string> queue)
        {
            if (queue == null) return null;
            string val = queue.Dequeue();

            if (val == "null") return null;
            else
            {
                TreeNode node = new TreeNode(Convert.ToInt32(val));
                node.left = Decode(queue);
                node.right = Decode(queue);
                return node;
            }

        }
    }

    //Driver method for testing
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(5);

            Codec codec = new Codec();
            string encodeString = codec.serialize(root);
            Console.WriteLine(encodeString);

            TreeNode node = codec.deserialize(encodeString);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
