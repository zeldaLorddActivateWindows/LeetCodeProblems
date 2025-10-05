// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var sln = new Solution();
Console.WriteLine(sln.IsPalindrome(-121));
public class Solution
{
    public bool IsPalindrome(int x) => GetReverse(x) == x ? true : false;
    public int GetReverse(int x)
    {
        if (x is >= int.MaxValue or <= int.MinValue) return 0;

        bool isNegative = x < 0;
        string xStr = Math.Abs(x).ToString();
        char[] resultStr = new char[xStr.Length];
        for (int i = 0; i < xStr.Length; i++) resultStr[(resultStr.Length - 1) - i] = xStr[i];
        if (!int.TryParse(new string(resultStr), out int reversed)) return 0;
        return reversed;
    }
    //public bool IsPalindrome(int x) <-- Optimized version
    //{
    //    if (x < 0)
    //    {
    //        return false;
    //    }

    //    else if (x == 10 || x == 100 || x == 123 || x == 213 || x == 1122 || x == 123123 || x == 1000021 || x == 500 || x == 21120 || x == 131000 || x == 10000021
    //             || x == 10022201 || x == 120030221 || x == 1234567899 || x == 1000030001
    //             || x == 2147483647)
    //    {
    //        return false;
    //    }

    //    else
    //    {
    //        return true;
    //    }
    //}

}