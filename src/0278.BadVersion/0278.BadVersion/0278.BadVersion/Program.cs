using System;

namespace _0278.BadVersion
{
    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            bool[] badVesion = { false, false, false, true, true, true, true, true, true };

            return badVesion[version];
        }
    }

    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while(left < right)
            {
                // It will overflow for big number
                //int mid = (left + right) / 2;
                
                //to avoid overflow
                int mid = left + (right - left) / 2; // this is same as (left + right) / 2

                if (IsBadVersion(mid) == true)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.FirstBadVersion(9));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
