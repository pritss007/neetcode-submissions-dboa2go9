public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, 1);

        //calculate left
         int left = 1;
        for(int i = 0; i < n; i++){
            result[i] = left;
            left *= nums[i];
        }

        //calculate right
        int right = 1;
        for(int i = n -1; i >= 0; i--){
            result[i] *= right;
            right *= nums[i];
        }
        return result;
    }
}
