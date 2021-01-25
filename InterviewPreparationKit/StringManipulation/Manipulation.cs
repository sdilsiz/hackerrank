using System.Linq;
using System;

public class Manipulation
{
    public static int makeAnagram(string a, string b)
    {

        // dcbac  abccd
        // bacdc  abccd abcdd
        // but bacdc and dcbad are not.
        //  accfgilmmnrsvwxxyyyz
        // bbdeeghhijjklmmmooppqrrstuvwwx
        // accf

        var aArr = a.ToCharArray().ToList();//.Sort(s => s).ToList();
        var bArr = b.ToCharArray().ToList();//.Sort(s => s).ToList();

        object p = String.Concat(aArr.OrderBy(c => c));
        object p1 = String.Concat(bArr.OrderBy(c => c));
        Console.WriteLine(p);
        Console.WriteLine(p1);

        var deleteCount = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (bArr.Any(s => s == a[i]))
            {
                var index = bArr.IndexOf(a[i]);
                bArr.RemoveAt(index);
                continue;
            }
            deleteCount++;
        }

        for (int i = 0; i < b.Length; i++)
        {
            if (aArr.Any(s => s == b[i]))
            {
                var index = aArr.IndexOf(b[i]);
                aArr.RemoveAt(index);

                continue;
            }
            deleteCount++;
        }

        return deleteCount;
    }


            // 5
            // AAAA =>3
            // BBBBB=>4
            // ABABABAB=>0
            // BABABA=>0
            // // AAABBB=>4
    public static int alternatingCharacters(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                ++count;
            }
        }
        return count;

    }
}

