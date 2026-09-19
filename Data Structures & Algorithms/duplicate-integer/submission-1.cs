public class Solution {
    public bool hasDuplicate(int[] nums) {
        return nums.Distinct().Count() != nums.Count();
    }
}