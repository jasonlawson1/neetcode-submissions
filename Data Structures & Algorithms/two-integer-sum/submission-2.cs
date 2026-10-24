public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(sums.ContainsKey(diff))
            {
                return new int[] {sums[diff], i};
            }
            else
            {
                sums.TryAdd(nums[i], i);
            }
        }
        return null;
    }
}
