// See https://aka.ms/new-console-template for more information
var sln = new Solution();
Console.WriteLine(sln.Convert(s: "PAHNAPLSIIGYIR", numRows: 3));

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s; 
        string[] splitResults = new string[numRows];
        for (int i = 0; i < numRows; i++) splitResults[i] = "";
        
        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            splitResults[currentRow] += c;
            if (currentRow == 0 || currentRow == numRows - 1)  goingDown = !goingDown; 
            currentRow += goingDown ? 1 : -1;
        }

        string result = "";
        foreach (var t in splitResults) result += t;
        return result;
    }
}
