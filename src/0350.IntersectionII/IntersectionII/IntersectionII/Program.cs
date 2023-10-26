using System;
using System.Collections;
using System.Collections.Generic;

namespace IntersectionII
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Hashtable hashtable1 = new Hashtable();
            foreach(int item in nums1)
            {
                if(hashtable1.Contains(item))
                {
                    hashtable1[item] = Convert.ToInt32(hashtable1[item]) + 1;
                }
                else
                {
                    hashtable1.Add(item, 1);
                }
            }

            Hashtable hashtable2 = new Hashtable();
            foreach (int item in nums2)
            {
                if (hashtable2.Contains(item))
                {
                    hashtable2[item] = Convert.ToInt32(hashtable2[item]) + 1;
                }
                else
                {
                    hashtable2.Add(item, 1);
                }
            }


            if (hashtable1.Count > hashtable2.Count)
                return GetIntersection(hashtable2, hashtable1);
            else
                return GetIntersection(hashtable1, hashtable2);

        }

        public int[] GetIntersection(Hashtable hashtable1, Hashtable hashtable2)
        {
            List<int> insectList = new List<int>();

            foreach(DictionaryEntry item in hashtable1)
            {
                if(hashtable2.Contains(item.Key))
                {
                    byte min = Math.Min(Convert.ToByte(item.Value), Convert.ToByte(hashtable2[item.Key]));
                    for(int i = 0; i < min; i++)
                    {
                        insectList.Add(Convert.ToInt32(item.Key));
                    }
                }
            }

            return insectList.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = { 1, 2, 2, 1 }, nums2 = { 2, 2 };
            int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4 };
            Solution solution = new Solution();
            int[] output = solution.Intersect(nums1, nums2);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
