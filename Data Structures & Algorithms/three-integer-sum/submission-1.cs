
public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var uniqueTriplets = new HashSet<Tuple<int, int, int>>();
        var result = new List<List<int>>();

        for (int i = 0; i < nums.Length - 1; i++)        
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int l = i + 1;
            int r = nums.Length - 1;
            int target = -nums[i];

            while (l < r)
            {
                int sum = nums[l] + nums[r];
                if (sum == target)
                {
                    var triplet = Tuple.Create(nums[i], nums[l], nums[r]);
                    uniqueTriplets.Add(triplet);
                    //while (l < r && nums[l] == nums[l + 1]) l++;
                    //while (l < r && nums[r] == nums[r - 1]) r--;
                    l++;
                    r--;
                }
                else if (sum < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }
        return uniqueTriplets.Select(x => new List<int>()
        {
            x.Item1, x.Item2, x.Item3
        }).ToList();
    }
}
