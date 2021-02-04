
using System;
public class BubbleSort
{

    public static void countSwaps(int[] a)
    {
        int temp;
        int swapCount = 0;

        for (int i = 0; i < a.Length; i++)
        {

            for (int j = 0; j < a.Length - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    // swap(a[j], a[j + 1]);
                    swapCount++;
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }

        }
        Console.WriteLine($"Array is sorted in {swapCount} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length - 1]}");

    }

}