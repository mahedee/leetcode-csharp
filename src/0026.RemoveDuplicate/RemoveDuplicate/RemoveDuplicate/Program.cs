using System;

namespace RemoveDuplicate
{
    public class Solution
    {
        // Array is sorted
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int i = 0;
            nums[i++] = nums[0];
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[j - 1])
                {
                    nums[i++] = nums[j];
                }
            }
            return i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            Console.WriteLine(new Solution().RemoveDuplicates(nums));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
