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

const findMaxAverage = (nums, k) => {
  let sum = 0;
  let maxSum = -Infinity;

  for (let i = 0; i < nums.length; i++) {
    sum += nums[i];
    if (i >= k) {
      sum -= nums[i - k];
    }
    if (i >= k - 1) {
      maxSum = Math.max(maxSum, sum);
    }
  }
  return maxSum / k;
};
