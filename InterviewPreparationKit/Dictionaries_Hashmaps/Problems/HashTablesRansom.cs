using System;
using System.Linq;
using System.Collections;


public static class HashTablesRansom
{
   public static void checkMagazine(string[] magazine, string[] note) {
 
   Array.Sort(magazine);
         Array.Sort(note);

        List<string> magList = magazine.ToList();

        foreach (string n in note)
        {
            if (!magList.Remove(n))
            {
                Console.WriteLine("No");
                return;
            }
        }

        Console.WriteLine("Yes");
        
      
    }

} 