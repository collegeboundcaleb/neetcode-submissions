public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(int i = 0; i<nums.Length; i++){

            int numPointer1 = nums[i];

            for(int j = 0; j <nums.Length; j++){

                int numPointer2 = nums[j];
                if(numPointer1 + numPointer2 == target && i != j ){
                    int[] finalAnswer = [i, j];
                    return finalAnswer;
                } 

            }
        }
        return [0];
    }
}
