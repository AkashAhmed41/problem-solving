/**
 * 1768. Merge Strings Alternately
 * Difficulty: Easy
 * Topic: Arrays / Strings
 * Link: https://leetcode.com/problems/merge-strings-alternately/
 *
 * Approach: Clean two-pointer — append one char from each string per iteration
 * Time:  O(m + n)
 * Space: O(m + n)
 *
 * Key Insight:
 * Each iteration of the loop contributes exactly one character from word1
 * and one from word2. No modulo needed — the alternation is implicit in
 * the order of append calls. Remaining characters are appended via Substring.
 */

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder result = new StringBuilder();
        int p1 = 0, p2 = 0;

        while (p1 < word1.Length && p2 < word2.Length) {
            result.Append(word1[p1++]); 
            result.Append(word2[p2++]); 
        }

        if (p1 < word1.Length)
            result.Append(word1.Substring(p1));
            
        if (p2 < word2.Length)
            result.Append(word2.Substring(p2));

        return result.ToString();
    }
}