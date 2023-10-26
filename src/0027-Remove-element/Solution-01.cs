public class Solution {
    public int RemoveElement(int[] nums, int val) {   
        int result = 0;
        foreach(int item in nums)
        {
            if(item != val)
            {
                nums[result] = item;
                result++;
            }
        }
        return result;
    }
}