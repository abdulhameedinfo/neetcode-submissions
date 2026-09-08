public class Solution {
    public int MaxProfit(int[] prices) {
        var l = 0;
        var r = 1;
        var maxProfit = 0;
        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
            {
                var profit = prices[r] - prices[l];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else {
                l = r;
            }
            r++;
        }
        return maxProfit;
    }
}
