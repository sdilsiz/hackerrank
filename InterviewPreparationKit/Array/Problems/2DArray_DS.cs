using System;


public static class DArray_DS
{
    public static void Run()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        // Console.WriteLine(arr.Length);
        // Console.Write(arr[0].Length);


        int result = hourglassSum(arr);
        Console.Write(result);
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }

     static int hourglassSum(int[][] arr)
        {





            var maxhourglassSum = -99999;
            var foundedI = 0;
            var foundedJ = 0;
            var rowLength = arr.Length;
            var columnLength = arr[0].Length;
            // return 32;
            // Console.WriteLine("arr.Length  " + arr.Length);
            Console.WriteLine("rowlength " + rowLength);
            Console.WriteLine("columnLength " + columnLength);
            //  Console.WriteLine("columnLength2 " + arr[0].Length);
            // Console.WriteLine("rank " + arr.Rank);

            for (int i = 0; i < rowLength; i++)
            {
                Console.WriteLine("****************");
                for (int j = 0; j < columnLength; j++)
                {

                    if ((i - 1 >= 0 && i + 1 <= rowLength - 1 && j - 1 >= 0 && j + 1 <= columnLength - 1))
                    {

                        Console.Write(i + "--" + j + "=>" + arr[i][j]);
                        Console.Write("&&");
                        var sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1]
                                                    + arr[i][j]
                                  + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];

                        if (sum > maxhourglassSum)
                        {
                            maxhourglassSum = sum;
                            foundedI = i;
                            foundedJ = j;
                        }
                    }
                }
            }

            return maxhourglassSum;
        }


}