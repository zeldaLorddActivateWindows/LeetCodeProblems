using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.VisualBasic;

var solution = new Solution();
int[] nums1 = new int[] { 1, 3};
int[] nums2 = new int[] { 2, 7 };

Console.WriteLine($"Solution: {solution.FindMedianSortedArrays(nums1: nums1, nums2: nums2)}");

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int sum = 0;
        var merged = nums1.Concat(second: nums2);
        var mergedArray = merged.ToArray(); 
        Array.Sort(mergedArray);
        int n = mergedArray.Length;
        if (n % 2 != 0) return mergedArray[n / 2];
        return (mergedArray[(n - 1) / 2] + mergedArray[n / 2]) / 2.0;
    }
}