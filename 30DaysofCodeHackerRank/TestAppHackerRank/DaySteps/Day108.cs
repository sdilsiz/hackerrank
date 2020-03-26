using System;
using System.Collections.Generic;

namespace TestAppHackerRank {
    /// <summary>
    /// Dictionaries and Maps
    /// </summary>
    internal class Day108 {
        internal static void Run() {

            var addressbookDict = new Dictionary<string, string>();
            _ = int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++) {
                var namePhoneNumber = Console.ReadLine();
                var namePhoneNumberArray = namePhoneNumber.Split(' ');
                if (namePhoneNumberArray.Length != 2) {
                    continue;
                }
                if (namePhoneNumberArray[1].Length == 8) {
                    addressbookDict.Add(namePhoneNumberArray[0], namePhoneNumberArray[1]);
                }
            }

            for (int i = 0; i < n; i++) {
                var query = Console.ReadLine();
                if (string.IsNullOrEmpty(query)) {
                    continue;
                }
                if (addressbookDict.ContainsKey(query)) {
                    Console.WriteLine($@"{query}={addressbookDict[query]}");
                } else {
                    Console.WriteLine($@"Not found");
                }
            }
            Console.Read();


        }
    }
}