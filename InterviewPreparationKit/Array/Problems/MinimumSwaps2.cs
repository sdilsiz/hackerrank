using System;
public class MinimumSwaps2
{
    // Complete the minimumSwaps function below.
    public static int minimumSwaps(int[] arr)
    {

        int i1 = 0;
        int count1 = 0;
        int temp1;
        int n = arr.Length;
        while (i1 < n)
        {
            if (arr[i1] != i1 + 1)
            {
                temp1 = arr[i1];
                arr[i1] = arr[temp1 - 1];
                arr[temp1 - 1] = temp1;
                count1++;
            }
            else
            {
                i1++;
            }
        }
        return count1;
    }
}