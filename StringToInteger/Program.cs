using System.Text;
using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
var sln = new Solution();
Console.WriteLine(sln.MyAtoi("20000000000000000000"));

public class Solution
{
    public int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        string result = Clean(s);
        if (result.Length == 0) return 0;
        if (result.Length == 1 && (result[0] == '-' || result[0] == '+')) return 0;

        try
        {
            long parsedValue = long.Parse(result);
            if (parsedValue > Int32.MaxValue) return Int32.MaxValue;
            if (parsedValue < Int32.MinValue) return Int32.MinValue;

            return (int)parsedValue;
        }
        catch (OverflowException)
        {
            return result[0] == '-' ? Int32.MinValue : Int32.MaxValue;
        }
        catch
        {
            return 0;
        }
    }

    public string Clean(string s)
    {
        s = s.Trim();
        if (s.Length == 0) return string.Empty;

        StringBuilder cleaned = new StringBuilder();
        int i = 0;

        if (s[0] == '+' || s[0] == '-')
        {
            cleaned.Append(s[0]);
            i++;
        }

        while (i < s.Length && char.IsDigit(s[i]))
        {
            cleaned.Append(s[i]);
            i++;
        }

        return cleaned.ToString();
    }
}
