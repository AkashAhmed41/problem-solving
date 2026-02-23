/**
 * 1456. Maximum Number of Vowels in a Substring of Given Length
 * Difficulty: Medium
 * Topic: Sliding Window
 * Link: https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
 *
 * Approach: Single loop sliding window with early exit
 * Time:  O(n) | Space: O(1)
 *
 * Key Insight:
 * Unify window initialization and sliding into one loop using index-based boundary checks
 * Add early exit: if currentVowels == k, the window is 100% vowels —
 * it's mathematically impossible to do better, so return immediately.
 */

const VOWELS = new Set(["a", "e", "i", "o", "u"]);

const isVowel = (char) => VOWELS.has(char);

const maxVowels = (s, k) => {
  let maxVowelCount = 0,
    currentVowelCount = 0;

  for (let i = 0; i < s.length; i++) {
    if (isVowel(s[i])) currentVowelCount++;
    if (i >= k && isVowel(s[i - k])) currentVowelCount--;
    if (i >= k - 1) {
      maxVowelCount = Math.max(maxVowelCount, currentVowelCount);
      if (maxVowelCount === k) return k;
    }
  }
  return maxVowelCount;
};
