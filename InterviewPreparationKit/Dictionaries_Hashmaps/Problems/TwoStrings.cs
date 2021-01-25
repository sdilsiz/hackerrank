using System.Text;
using System;
using System.Linq;

using System.IO;
using System.Collections;
 
using System.Collections.Generic;
 

public class TwoStrings
{
    static String twoStrings1(String s1, String s2)
    {
        short counter = 0;
        Dictionary<char, short> lista = new Dictionary<char, short>();

        for (int x = 0; x < s1.Length; x++)
        {
            if (!lista.ContainsKey(s1[x]))
                lista.Add(s1[x], 1);
            else
                lista[s1[x]] += 1;
        }

        for (int y = 0; y < s2.Length; y++)
        {
            if (lista.ContainsKey(s2[y]))
            {
                counter++;
                break;
            }
        }

        return (counter > 0 ? "YES" : "NO");

    }

    static string twoStrings(string s1, string s2)
    {
        var subStrings1 = SubString(s1);
        var subStrings2 = SubString(s2);

        foreach (var subString1 in subStrings1)
        {
            foreach (var subString2 in subStrings2)
            {
                var asd = subString1.Intersect(subString2).Any();
                Console.Write(asd);
                if (asd)
                { return "YES"; }

            }

        }
        return "NO";


    }

   
    
    static List<string> SubString(String str)
    {
         
        List<string> result = new List<string>();
        var n = str.Length;
        for (int i = 0; i < n; i++)
            for (int j = 1; j <= n - i; j++)
                result.Add(str.Substring(i, j));
        return result;
    }

}