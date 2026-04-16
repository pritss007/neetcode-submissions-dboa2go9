public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> map = new();

        int maxLen = 0;
        int maxFreq = 0 ;
        int left = 0;

        for(int right = 0; right < s.Length; right++){
            char c = s[right];
            map[c] = map.GetValueOrDefault(c, 0) +1;
            maxFreq = Math.Max(maxFreq, map[c]);
            while((right - left + 1) - maxFreq > k){
                map[s[left]]--;
                left++;
            }
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        return maxLen;
    }
}
