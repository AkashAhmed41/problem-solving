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

public class Solution {
    public static readonly HashSet<char> Vowels = new() {'a', 'e', 'i', 'o', 'u'};

    public static bool IsVowel (char c) => Vowels.Contains(c);

    public int MaxVowels(string s, int k) {
        int maxVowelCount = 0;
        int currentVowelCount = 0;

        for(int i = 0; i < s.Length; i++) {
            if(IsVowel(s[i])) currentVowelCount++;
            if(i >= k && IsVowel(s[i-k])) currentVowelCount--;
            if(i >= k-1) {
                maxVowelCount = Math.Max(maxVowelCount, currentVowelCount);
                if(maxVowelCount == k) return maxVowelCount;
            }
        }
        return maxVowelCount;
    }
}