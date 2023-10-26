using System;

namespace Sqrt
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x < 2) return x;
            int left = 2;

            // squre root value cannot be greater than half of its value
            // so we consider right value as x / 2
            int right = x / 2;

            while(left <= right)
            {
                int mid = (left + right) / 2; //guessing value
                long squreVal = (long) mid * mid;
                if (x > squreVal)
                    left = mid + 1;
                else if (x < squreVal)
                    right = mid - 1;
                else return mid;
            }
            return right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MySqrt(2147395599));
            Console.WriteLine(solution.MySqrt(8));
            Console.WriteLine(solution.MySqrt(16));
            Console.WriteLine(solution.MySqrt(18));
            Console.ReadKey();
        }
    }
}
