using System;

namespace SearchInsert
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        public int BinarySearch(int[] data, int lowerBound, int uppperBound, int item)
        {
            if (lowerBound > uppperBound)
                return lowerBound; // Location where would be

            int mid = (lowerBound + uppperBound) / 2;

            if (data[mid] == item) return mid;

            if (data[mid] < item)
                lowerBound = mid + 1;
            else
                uppperBound = mid - 1;

            return BinarySearch(data, lowerBound, uppperBound, item);
        }
    }

    class Program
    {

        //Driver method for testing
        static void Main(string[] args)
        {
            int[] data = { 1, 3, 5, 6 };
            int target = 0;
            Console.WriteLine(new Solution().SearchInsert(data, target));
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
