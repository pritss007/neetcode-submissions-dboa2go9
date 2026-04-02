public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> val = new();
        foreach(int num in nums){
            if(val.Contains(num)){
                return true;
            }
            val.Add(num);
        }
        return false;
    }
}