// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
int x = 123;
var sln = new Solution();
Console.WriteLine(x);
Console.WriteLine(sln.Reverse(120));

public class Solution
{
    public int Reverse(int x)
    {
        if (x is >= int.MaxValue or <= int.MinValue) return 0;

        bool isNegative = x < 0;
        string xStr = Math.Abs(x).ToString();
        char[] resultStr = new char[xStr.Length];
        for (int i = 0; i < xStr.Length; i++) resultStr[(resultStr.Length - 1) - i] = xStr[i];
        if (!int.TryParse(new string(resultStr), out int reversed)) return 0;
        return isNegative ? -reversed : reversed;
    }
}
