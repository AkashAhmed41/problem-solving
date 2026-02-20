/**
 * Approach 3: Single pass — swap non-zero with write pointer position
 * Time:  O(n)
 * Space: O(1)
 *
 * Key Insight:
 * Instead of overwriting and then filling, swap nums[i] with nums[writeIndex]
 * whenever a non-zero is found. This moves zeroes backward implicitly —
 * whatever was at writeIndex gets pushed to i's old position.
 * One pass, no fill step needed.
 *
 * Trade-off:
 * Fewer total writes when the array has few zeroes (no wasted fill pass).
 * More swaps when zeroes are scattered — but always O(n) comparisons.
 */

public class Solution {
    public void MoveZeroes(int[] nums) {
        int writeIndex = 0;
        for(int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                (nums[i], nums[writeIndex]) = (nums[writeIndex], nums[i]);
                writeIndex++;
            }
        }
    }
}

