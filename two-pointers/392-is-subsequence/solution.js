/**
 * 392. Is Subsequence
 * Difficulty: Easy
 * Topic: Two Pointers
 * Link: https://leetcode.com/problems/is-subsequence/
 *
 * Approach: Two pointer with early exit
 * Time:  O(n) best/worst — but exits early when s fully matched
 * Space: O(1)
 *
 * Key Insight:
 * Once trackingIndex reaches s.Length, we've matched everything — no point
 * scanning the rest of t. Especially valuable when s is short
 * and the match happens early in a very long t.
 */

var isSubsequence = function (s, t) {
  if (s.length > t.length) return false;
  if (s.length === 0) return true;

  let trackingIndex = 0;
  for (let i = 0; i < t.length; i++) {
    if (t[i] === s[trackingIndex]) {
      trackingIndex++;
      if (trackingIndex === s.length) {
        return true;
      }
    }
  }
  return false;
};
