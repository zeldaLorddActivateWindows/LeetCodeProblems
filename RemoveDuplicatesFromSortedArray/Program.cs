
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        //HashSet<int> set = new HashSet<int>();
        //set = nums.ToHashSet();
        //var tmp = set.ToArray();

        //for (int i = 0; i < tmp.Length; i++) nums[i] = tmp[i];
        //int k = tmp.Length;
        //return k;

        //more optimized with linq:
        //var unique = nums.Distinct().ToArray(); 
        //Array.Copy(unique, nums, unique.Length);
        //return unique.Length;
        //nvm it was worse

        //surely
        int i = 0; 
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j]; 
            }
        }
        return i + 1;
        //0ms runtime gg
    }
}


