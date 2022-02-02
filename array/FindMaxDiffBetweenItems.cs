public class FindMaxDiffBetweenItems
{
    public int FindMaxDiff(int[] arr)
    {

        //high level steps:
        //find max's position in one loop with run time O(n)
        //find min's position from index until max's position with run time O(n)
        //return diff
        int maxVal = arr[0];
        int maxDiffVal = 0;
        int maxIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
                maxIndex = i;
            }

            if (maxVal - arr[i] > maxDiffVal)
            {
                maxDiffVal = maxVal - arr[i];
            }
        }

        return maxDiffVal;

    }

    public int Run()
    {
        int[] arr = new int[] { 5, 3, 8, 15, 2, 4, 5, 25, 1, 9, 4 };
        return FindMaxDiff(arr);
    }
}