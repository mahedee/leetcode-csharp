using System.Collections;

namespace TwoSum
{

    /// <summary>
    /// Solution 1: Brute force method
    /// Complexity: O(n^2)
    /// </summary>
    public class Solution1
    {
         public static int[] TwoSum(int[] nums, int target)
        {
            int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        twoSum[0] = i;
                        twoSum[1] = j;

                        return twoSum;
                    }
                }
            }
            return twoSum;
        }
    }




    /// <summary>
    /// Optimized solution
    /// Complexity: O(n)
    /// </summary>
    public class Solution2
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            //For fast retrival
            Hashtable hashtable = new Hashtable();

            // add first number in the array to the hashtable
            // hashtable["key"] = value;
            // here value is index of the number in the array
            // value will be used to return the index of the number
            hashtable[nums[0]] = 0; 

            // loop through the array starting from 1 not 0
            // because we already added first number to the hashtable
            for (int i = 1; i < nums.Length; i++)
            {
                // difference or complement
                int diff = target - nums[i];

                // if hashtable contains the difference
                // return the index of the difference and current number
                // else add current number to the hashtable
                if (hashtable.Contains(diff))
                {
                    return new int[2] { (int)hashtable[diff], i };
                }
                else
                {
                    hashtable[nums[i]] = i;
                }
            }

            return null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,7,11,15};
            int target = 9;

            int[] twoSum = Solution1.TwoSum(nums, target);
            twoSum = Solution2.TwoSum(nums, target);
        }
    }
}
