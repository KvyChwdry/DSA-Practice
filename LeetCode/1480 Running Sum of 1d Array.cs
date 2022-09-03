//Link: https://leetcode.com/problems/running-sum-of-1d-array/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int runningSum = 0;
        for(int i = 0; i < nums.Count(); i++)
        {
            runningSum += nums[i];
            nums[i] = runningSum;
        }
        
        return nums;
    }
}
