public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> hs = new HashSet<int>();

        foreach(int i in nums)
        {
            if(!hs.Contains(i))
            hs.Add(i);
            else
            return true;
        }
       return false;

         
    }
}