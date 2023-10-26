using System;

namespace PerfectSquare
{
    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            // Corner case
            if (num == 1) return true;

            int left = 0;
            int right = num / 2;

            while(left <= right)
            {
                // this is actually mid = (left + right) / 2
                // uses follwing technique to avoid overflow

                int mid = left + (right - left) / 2;

                long squareValue = (long)mid * mid;
                if(squareValue == num) return true;
                if (squareValue > num)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPerfectSquare(4));
            Console.WriteLine(new Solution().IsPerfectSquare(16));
            Console.WriteLine(new Solution().IsPerfectSquare(14));
            Console.WriteLine(new Solution().IsPerfectSquare(808201));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
