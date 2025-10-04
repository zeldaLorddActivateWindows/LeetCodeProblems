// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;
        int start = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            if (charIndexMap.ContainsKey(s[end]))
            {
                start = Math.Max(start, charIndexMap[s[end]] + 1);
            }

            charIndexMap[s[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}

//public class Solution
//{
//    public unsafe int LengthOfLongestSubstring(string s)
//    {
//        int* lastSeen = stackalloc int[128];
//        int maxLen = 0, start = 0;

//        for (int i = 0; i < 128; i++) lastSeen[i] = 0; <-- nerd solution

//        fixed (char* p = s)
//        {
//            for (int end = 0; end < s.Length; end++)
//            {
//                start = Math.Max(start, lastSeen[p[end]]);
//                maxLen = Math.Max(maxLen, end - start + 1);
//                lastSeen[p[end]] = end + 1;
//            }
//            return maxLen;
//        }
//    }
//}