using System;

namespace PowerOfThree
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            // 1162261467 is 3^19,  3^20 is bigger than int  
            return (n > 0 && 1162261467 % n == 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPowerOfThree(27));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
