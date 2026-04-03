public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> output = new();

        for(int i = 0; i < nums.Length; i++){
            int result = 1;
            for(int j = 0; j < nums.Length; j++){
                if(i == j){
                    continue;
                }
                result *= nums[j];
            }
            output.Add(result);
        }
        return output.ToArray();
    }
}
