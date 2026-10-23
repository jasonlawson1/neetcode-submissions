class Solution {
    public boolean hasDuplicate(int[] nums) {
        Map<Integer, Integer> dupe = new HashMap<>();
        for (int i = 0; i < nums.length; i++){
            if(dupe.containsKey(nums[i])){
                return true;
            }
            dupe.put(nums[i], 0);
        }
        return false;
    }
}