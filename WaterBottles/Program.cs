// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Solution sln = new Solution();
sln.NumWaterBottles(9, 3);

public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int totalDrank = numBottles;
        int empty = numBottles;

        while (empty >= numExchange)
        {
            int newBottles = empty / numExchange; 
            int remainder = empty % numExchange; 
            totalDrank += newBottles;
            empty = newBottles + remainder;
        }

        return totalDrank;
    }
}