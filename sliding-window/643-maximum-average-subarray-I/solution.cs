/**
 * 643. Maximum Average Subarray I
 * Difficulty: Easy
 * Topic: Sliding Window
 * Link: https://leetcode.com/problems/maximum-average-subarray-i/
 *
 * Approach: Single loop sliding window with index-based window tracking
 * Time:  O(n) | Space: O(1)
 *
 * Key Insight:
 * Unify window initialization and sliding into one loop by checking
 * when the window has reached size k. Eliminates the separate
 * first-window setup loop — same complexity, tighter structure.
 */

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0;
        double maxSum = double.MinValue;

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (i>=k) {
                sum-=nums[i-k];
            }
            if (i>=k-1) {
                maxSum = Math.Max(maxSum, sum);
            }
        }
        return maxSum/k;
    }
}