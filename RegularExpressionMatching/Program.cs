using System.Text.RegularExpressions;
using System.Threading.Channels;
Solution solution = new Solution();

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        //    var oldP = p;
        //    if (!Regex.IsMatch(s, pattern: "^[a-z]+$")) return false;
        //    if (!Regex.IsMatch(p, pattern: "^[a-z.*]+$")) return false;
        //    if (p.Contains('.'))
        //    {

        //        int i = p.IndexOf('.');
        //        if (i != -1) 
        //        {
        //            p = p.Substring(0, i) + s[i] + p.Substring(i + 1);
        //        }
        //    }
        //    if (p.Contains('*'))
        //    {

        //        int i = p.IndexOf('*');
        //        if (i != -1)
        //        {
        //            if (oldP[i - 1] == '.')  return true;
        //            if ()
        //            p = p.Substring(0, i) + s[i-1] + p.Substring(i + 1);
        //        }
        //    }
        //    if(p == s) return true;
        //    return false;
        return Regex.IsMatch(s, "^" + p + "$");
    }
}
