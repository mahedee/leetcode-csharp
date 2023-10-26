using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                int a = numbers[i];
                int b = target - a;

                int index = FindIndex(numbers, 0, numbers.Length - 1, b);

                if(index != -1 && index != i)
                {
                    //Arrange in ascending order
                    if(index < i)
                    {
                        return new int[] { index + 1, i + 1 };
                    }
                    return new int[] { i + 1, index + 1 };
                }
            }
            return new int[2];
        }

        // Binary search
        public int FindIndex(int[] data, int lowerBound, int upperBound, int item)
        {
            if (lowerBound > upperBound) return -1;
            int mid = (lowerBound + upperBound) / 2;

            if (data[mid] == item) return mid;

            if (data[mid] > item)
                upperBound = mid - 1;
            if (data[mid] < item)
                lowerBound = mid + 1;

            return FindIndex(data, lowerBound, upperBound, item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 7, 11, 15 };
            //int[] positions = new Solution().TwoSum(numbers, 19);

            int[] numbers = { 1, 2, 3, 4, 4, 9, 56, 90 };
            int[] positions = new Solution().TwoSum(numbers, 8);

            //Console.WriteLine(position);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
