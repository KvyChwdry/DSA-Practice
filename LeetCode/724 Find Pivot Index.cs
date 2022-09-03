//Link: https://leetcode.com/problems/find-pivot-index/

public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums.Length == 0) return 0;
        int output = -1;
        int rightSum = 0, leftSum = nums.Sum();
        for(int i = 0; i < nums.Length; i++)
        {
            leftSum -= nums[i];
            if(rightSum == leftSum)
            {
                output = i;
                break;
            }
            rightSum += nums[i];
        }
        
        return output;
    }
}
