/**
 * 2215. Find the Difference of Two Arrays
 * Difficulty: Easy
 * Topic: Array, Hash Table
 * Link: https://leetcode.com/problems/find-the-difference-of-two-arrays/
 *
 * Approach: Set difference using HashSet.ExceptWith()
 * Time:  O(n + m) — building both HashSets is O(n + m),
 *                   ExceptWith takes O(n) and O(m)
 * Space: O(n + m) — two HashSets + copies for results
 *
 * Key Insight:
 * Convert both arrays to HashSets upfront — this handles deduplication for free
 * and upgrades every membership check from O(n) to O(1).
 * Use ExceptWith() on copies of the sets to find elements unique to each,
 * then convert the final HashSets to Lists for the return type.
 */

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet <int> set1 = new HashSet<int>(nums1);
        HashSet <int> set2 = new HashSet<int>(nums2);

        HashSet <int> copy1 = new HashSet<int>(set1);
        HashSet <int> copy2 = new HashSet<int>(set2);

        copy1.ExceptWith(set2);
        copy2.ExceptWith(set1);

        return new List<IList<int>> {
            copy1.ToList(),
            copy2.ToList()
        };
    }
}