using System;

public class Fibonacci
{
    public void Print(int maxNum)
    {
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, .
        int prev = 0;
        int cur = 1;
        int sum = 0;
        Console.WriteLine(prev + ", " + cur + ", ");
        while (sum < maxNum)
        {
            sum = prev + cur;
            Console.WriteLine(sum + ",");
            prev = cur;
            cur = sum;
        }
    }
}