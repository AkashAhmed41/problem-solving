/**
 * 1071. Greatest Common Divisor of Strings
 * Difficulty: Easy
 * Topic: Arrays / Strings
 * Link: https://leetcode.com/problems/greatest-common-divisor-of-strings/
 *
 * Approach: Concatenation check + integer GCD
 * Time:  O((m+n) * log(min(m,n))) — GCD is log time, string ops are O(m+n)
 * Space: O(m+n) — for the concatenated strings
 *
 * Key Insight:
 * Mathematical proof: A GCD string exists if and only if str1+str2 == str2+str1.
 * If this holds, the GCD string's length is exactly gcd(len1, len2).
 * No recursion, no loop — just one check and one integer GCD call.
 *
 * Why does str1+str2 == str2+str1 work?
 * If both strings are made of repeating copies of some base t, then:
 *   str1+str2 = t*a + t*b = t*(a+b)
 *   str2+str1 = t*b + t*a = t*(b+a)
 * These are equal. Conversely, if they're NOT equal, no such t can exist.
 */

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1) return "";

        return str1[..Gcd(str1.Length, str2.Length)];
    }

    private int Gcd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

