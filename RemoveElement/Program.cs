// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
int val = 3;
var sln = new Solution();
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]);
}

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int newLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[newLength] = nums[i];
                newLength++;
            }
        }
        return newLength;
    }
}
