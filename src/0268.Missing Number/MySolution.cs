public class Solution {
    public int MissingNumber(int[] nums) {
        
        // sort the nums
        for(int i = 1; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length - i; j++)
            {
                if(nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
        
        // check missing number
        for(int k = 0; k < nums.Length; k++)
        {
            if (k != nums[k])
                return k;
        }

        // if missing number not found means it cannot hold upper number
        return nums.Length;
    }
}