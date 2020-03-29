using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {

	/// <summary>
	/// Generics
	/// </summary>
	public class Day121 {
        public static void Run() {

			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++) {
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++) {
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			PrintArray<String>(stringArray);
		}

		private static void PrintArray<T>(T[] intArray) {
			for (int i = 0; i < intArray.Length; i++) {
				Console.WriteLine(intArray[i]);
			}
			
		}
	}
}
