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
 * Each iteration contributes exactly one character from word1 and one from word2.
 * Alternation is implicit in the order of push() calls — no modulo needed.
 * We use an array + join() instead of string concatenation to avoid O(n²) cost.
 */

const mergeAlternately = (word1, word2) => {
  const result = [];
  let p1 = 0,
    p2 = 0;

  while (p1 < word1.length && p2 < word2.length) {
    result.push(word1[p1++]);
    result.push(word2[p2++]);
  }

  if (p1 < word1.length) {
    result.push(word1.slice(p1));
  }

  if (p2 < word2.length) {
    result.push(word2.slice(p2));
  }

  return result.join("");
};
