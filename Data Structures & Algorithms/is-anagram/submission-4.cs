public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] hManyW= new int[26];
        int[] hManyWt= new int[26];
        foreach(char c in s)
        {
            hManyW[c-'a']++;
        }
        foreach(char cS in t)
        {
            hManyWt[cS - 'a']++;
        }
        for(int i =0;i<26;i++)
        {
            if(hManyW[i] != hManyWt[i])
            {
                return false;
            }
        }
        return true;
    }
}
