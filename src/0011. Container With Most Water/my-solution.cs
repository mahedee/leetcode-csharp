public class Solution {
    public int MaxArea(int[] height) 
    {
        int max = 0;

        /* The comment is explaining the approach used in the code to find the maximum water of a container. It
        mentions that two pointers are used, one starting from the left side of the array and another
        starting from the right side. These pointers will be used to calculate the area of the container. */
        for(int i = 0, j = height.Length - 1; i < j;)
        {
            int waterInContainer = 0;

            // If the left side line is smaller than right side
            if(height[i] < height[j])
            {
                waterInContainer = (j - i) * height[i];
                i++;
            }
            else
            {
                waterInContainer = (j - i) * height[j];
                j--;
            }
            if(waterInContainer > max)
            {
                max = waterInContainer;   
            }
        }
        return max;
    }
}

/*
The proof of why the solution works is important to understand. Following is its summary:

Consider we start with i = 0 and j = height.size() - 1. That is, i points to the first column and j points to the last column.
Now suppose that h(i)>h(j) (we are not loosing generality by this assumption)
We calculate the water capacity for the i, j. It will be h(j)*(j-i).
Now see that if we fix j at height.size() - 1 and vary i, we cannot get a greater water capacity. Why?
capacity = min of both heights * width between them. Since capacity is the product of these two terms, we will look at each term individually.
First about the width. It is easy to see that for all other i's (i = 1, 2,... ,height.size()-2) we will have a lesser width.
Second, the height will be the minimum of the column at i and at j, i.e. min(h(i),h(j)). But this value will be always less than h(j)
So both factors in the calculation of the capacity will be smaller and hence we can skip considering all the cases where i = 1, 2, 3, ..., height.size()-2 and j = height.size()-1
Which basically means that we can simply move j to j-1.
This is how I understood it and I hope this explanation makes it easy to understand.
*/