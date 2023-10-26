public class Solution {
    public int SingleNumber(int[] nums) {

        int result = 0;
        foreach(int item in nums)
        {
            // bitwise OR or XOR will return 0 if two operand is same. 
            // Like a ^ b  = 0 means a and b is same
            result = result ^ item;
        }

        return result;
        
    }
}

/*
Example:
0 ^ 2 = 2
0 ^ 2 ^ 2 = 0
0 ^ 2 ^ 2 ^ 1 = 0

0 ^ 4 = 4
0 ^ 4 ^ 1 = 5
0 ^ 4 ^ 1 ^ 2 = 7
0 ^ 4 ^ 1 ^ 2 ^ 1 = 6
0 ^ 4 ^ 1 ^ 2 ^ 1 ^ 2 = 4

*/