public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> map = new();
        int maxCount = 0;
        int left = 0;        

        for(int right = 0; right < s.Length; right++){
            while(map.Contains(s[right])){
                map.Remove(s[left]);
                left++;
            }

            map.Add(s[right]);
            maxCount = Math.Max(maxCount, right - left +1);
        }
        return maxCount;
    }
}
