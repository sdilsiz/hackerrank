

// https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

using System;
using System.Linq;
using System.Text;
public class RepeatedString
{

    public static long repeatedString(string s, long n)
    {

        if (n >= 1000000000000) { return n; }
        if (!s.Contains("a")) return 0;
        #region     First Solution

        // if (s.Length > n)
        // {
        //     var x = s.Substring(0, (int)n).Count(a => a == 'a');
        //     return x;
        // }
        // else
        // {

        //     long multiply = (n / s.Length);
        //     var x = s.Count(a => a == 'a') * multiply;
        //     var mod = n % s.Length;
        //     var y = s.Substring(0, (int)mod).Count(a => a == 'a');
        //     return x + y;
        // }
        #endregion first Solution            
        #region Second Solution
        var x = s.Length > n ?
                            s.Substring(0, (int)n).Count(a => a == 'a')
                            : ((s.Substring(0, (int)(n % s.Length)).Count(a => a == 'a')) + (s.Count(a => a == 'a') * (n / s.Length)));

        return x;
        #endregion  Second Solution



    }
}