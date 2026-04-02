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

        var orderedDic = map.OrderByDescending(k => k.Value);

        int[] result = new int[k];
         foreach(var car in orderedDic){
            if(k > 0)
        {
           result[k-1] = car.Key;
                k--;
        }
        else{
            break;
        }
            }
        return result;
    }
}
