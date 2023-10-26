using System;

namespace Tribonacci
{
    public class TribCalculator
    {
        //Constraint : 0 <= n <= 37
        private static int n = 38;
        public int[] nums = new int[n];

        public TribCalculator()
        {
            nums[1] = 1;
            nums[2] = 1;

            //If your array size is n means 0 to n-1
            Trib(n-1);
        }
        public int Trib(int n)
        {
            if (n <= 0) return 0;

            //If it is pre calculated for previous value. No need to calculate again.
            if (nums[n] != 0) return nums[n];
            //else if (n == 1 || n == 2)
            //    return 1;
            else
            {
                nums[n] = Trib(n - 1) + Trib(n - 2) + Trib(n - 3);
                return nums[n];
            }

        }
    }

    public class Program
    {
        static TribCalculator tribCalculator = new TribCalculator();

        public static int Tribonacci(int n)
        {
            return tribCalculator.nums[n];
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Program.Tribonacci(4));
            Console.WriteLine(Program.Tribonacci(25));

            Console.WriteLine(Program.Tribonacci(5));
            Console.ReadKey();
        }
    }
}
