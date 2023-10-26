using System;

namespace PowerOfTwo
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            // Because the range of an integer = -2147483648(-2 ^ 31) ~2147483647(2 ^ 31 - 1), 
            // the max possible power of two = 2 ^ 30 = 1073741824.
            return n > 0 && (1073741824 % n == 0);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPowerOfTwo(1));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
