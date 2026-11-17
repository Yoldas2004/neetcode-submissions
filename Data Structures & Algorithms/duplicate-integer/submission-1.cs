public class Solution {
    public bool hasDuplicate(int[] nums) {
       // bool isIt = false;
        int n=nums.Length;
    for(int i =0;i<n;i++)
    {
        for(int j=i+1;j<n;j++)
        {
            if(nums[i]==nums[j])
            {
                return true;
            }
        }
    }
return false;
    }
}