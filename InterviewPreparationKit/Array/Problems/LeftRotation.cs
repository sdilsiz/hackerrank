

public static class LeftRotation
{


    public static void Run()
    {


        Console.WriteLine("Hello World!");
        //73642 60581
        //int[] a = new int[5] { 1, 2, 3, 4, 5 };
        int[] a = new int[73642];

        var arrayStr = File.ReadAllText("testArray.txt");
        //var array = arrayStr.Split(' ');

        int[] array = Array.ConvertAll(arrayStr.Split(' '), aTemp => Convert.ToInt32(aTemp))
   ;

        var d = 60581;
        a = rotLeft(a, d);

        for (var i = 0; i < a.Length; i++)
        {
            Console.Write("---" + a[i]);
        }

    }

    static int[] rotLeft(int[] a, int d)
    {
        #region doesn't work all test cases 

        //if (d > a.Length) { return a; }
        //for (var j = 0; j < d; j++) {
        //    var temp = new int[a.Length];
        //    Array.Copy(a, temp, a.Length);
        //    for (var i = 0; i < a.Length; i++) {
        //        if (i == 0) {
        //            a[^1] = temp[i];
        //        } else {
        //            a[i - 1] = temp[i];
        //        }
        //    }
        //}
        //return a;
        #endregion

        ///BEST Practice
        int[] arr = new int[a.Length];
        int N = a.Length;
        for (int i = 0; i < N; i++)
        {
            arr[i] = a[(i + d) % N];
        }

        return arr;
    }


}