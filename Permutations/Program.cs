
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var sln = new Solution();
int[] nums = { 1, 2, 3 };
var smth = sln.Permute(nums);
Console.WriteLine(smth.Count());

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        perm(0, nums, result);
        return result;
    }

    void perm(int pos, int[] nums, IList<IList<int>> result)
    {
        if (pos == nums.Length)
        {
            result.Add(nums.ToArray());
            return;
        }

        for (int i = pos; i < nums.Length; i++)
        {
            SwapValues(nums, i, pos);
            perm(pos + 1, nums, result);
            SwapValues(nums, i, pos); 
        }
    }

    public static void SwapValues(int[] source, int index1, int index2)
    {
        int temp = source[index1];
        source[index1] = source[index2];
        source[index2] = temp;
    }
}

