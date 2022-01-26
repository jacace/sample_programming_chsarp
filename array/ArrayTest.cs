using System;

public class ArrayTest
{
    private int[] build()
    {
        int[] array = new int[] { 3, 8, -1, 5 };
        return array;
    }

    public void Run()
    {
        int[] array = build();
        Array.Sort(array);
        Console.WriteLine("Larget number is: " + array[array.Length - 1]);
        Console.WriteLine("2nd larget number is: " + array[array.Length - 2]);

    }

}