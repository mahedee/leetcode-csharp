using System;
using System.Collections;
using System.Collections.Generic;

namespace Intersection
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            // A HashSet<T> is an unordered collection of the unique elements
            HashSet<int> hashset1 = new HashSet<int>();
            HashSet<int> hashset2 = new HashSet<int>();
            HashSet<int> temp = new HashSet<int>();

            // Remove duplicate value
            // For fast retrieval
            foreach (int item in nums1)
                hashset1.Add(item);

            foreach (int item in nums2)
                hashset2.Add(item);

            if (hashset1.Count > hashset2.Count)
            {
                temp = hashset1;
                hashset1 = hashset2;
                hashset2 = temp;
            }

            int[] intersection = new int[hashset1.Count];
            int i = 0;
            foreach(int item in hashset1)
            {
                if (hashset2.Contains(item))
                {
                    intersection[i] = item;
                    i++;
                }
            }

            Array.Resize<int>(ref intersection, i);
            return intersection;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            Solution solution = new Solution();
            solution.Intersection(nums1, nums2);
            Console.ReadKey();
        }
    }
}
