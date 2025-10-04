// See https://aka.ms/new-console-template for more information
int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
Solution sln = new Solution();
Console.WriteLine(sln.MaxArea(height));


public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0, j = height.Length - 1;
        int maxArea=0;
        while (i < j)
        {
            int area = Math.Min(height[i], height[j]) * (j - i);
            maxArea = Math.Max(maxArea, area);
            if (height[i] < height[j]) i++;
            else j--;
        }
        return maxArea;
    }
}

