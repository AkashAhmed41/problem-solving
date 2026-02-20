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

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length > t.Length) return false;
        if(s.Length == 0) return true;

        int trackingIndex = 0;
        for(int i = 0; i < t.Length; i++) {
            if(t[i] == s[trackingIndex]){
                trackingIndex++;
                if(trackingIndex == s.Length) {
                    return true;
                }
            }
        }
        return false;
    }
}