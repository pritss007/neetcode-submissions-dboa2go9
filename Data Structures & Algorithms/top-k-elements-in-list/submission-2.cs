public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(!map.TryGetValue(nums[i], out int value))
            {
                map[nums[i]] = 1;
            }
            else{
                map[nums[i]]++;
            }
        }

        return map.OrderByDescending(k => k.Value).Select(s => s.Key).Take(k).ToArray();
    }
}
