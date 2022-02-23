// C# program to illustrate the concept
// of SortedDictionary<TKey, TValue>()
// in SortedDictionary
using System;
using System.Collections.Generic;
namespace priorityQueues{
	public class Sort
	{

		// Main method
		public static void SortedDictionary()
		{

			// Create a new SortedDictionary
			// of strings, with int keys.
			SortedDictionary<int, string> sortedDict =
			new SortedDictionary<int, string>(new CustomComparer());

			// Adding key/value pairs in sortedDict
			sortedDict.Add(234, "C");
			sortedDict.Add(998, "C++");
			sortedDict.Add(3, "C#");

			// Display the key/value pairs
			foreach (KeyValuePair<int, string> pair in sortedDict)
			{
				Console.WriteLine("Key: {0} and Value: {1}",
									pair.Key, pair.Value);
			}
		}

	}
	public class CustomComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			// do your own comparison however you like; return a negative value
			// to indicate that x < y, a positive value to indicate that x > y,
			// or 0 to indicate that they are equal.

			return y-x;
		}
	}

}

