public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

    for (int i = 0; i < nums.Length; i++)
    {
        var diff = target - nums[i];

        if (map.TryGetValue(diff, out int value))
        {
            return new int[] { value, i };
        }

        map[nums[i]] = i;
    }

    return new int[] { };
    }
}
