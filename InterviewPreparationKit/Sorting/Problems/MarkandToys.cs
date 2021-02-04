
using System;
using System.Collections.Generic;

public class MarkandToys
{

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {


        Array.Sort(prices);
        int maksimum = 0;
        int sumofValues = 0;
        foreach (var item in prices)
        {

            if (sumofValues < k)
            {
                if (sumofValues + item > k) { break; }
                sumofValues += item;
                maksimum++;
            }
            else
            {
                break;
            }
        }
        return maksimum;

    }
}