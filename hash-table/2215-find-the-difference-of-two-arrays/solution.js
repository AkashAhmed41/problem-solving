/**
 * 2215. Find the Difference of Two Arrays
 * Difficulty: Easy
 * Topic: Array, Hash Table
 * Link: https://leetcode.com/problems/find-the-difference-of-two-arrays/
 *
 * Approach: Set difference using filter + has
 * Time:  O(n + m) — building both Sets is O(n + m),
 *                   filtering each is O(n) and O(m) with O(1) has() per element
 * Space: O(n + m) — two Sets + result arrays
 *
 * Key Insight:
 * Convert both arrays to Sets upfront — this handles deduplication for free
 * and upgrades every membership check from O(n) to O(1).
 * Spread each Set into an array to access .filter(),
 * then check membership in the OTHER Set to find the difference.
 */

const findDifference = (nums1, nums2) => {
  const set1 = new Set(nums1);
  const set2 = new Set(nums2);

  return [
    [...set1].filter((e) => !set2.has(e)),
    [...set2].filter((e) => !set1.has(e)),
  ];
};
