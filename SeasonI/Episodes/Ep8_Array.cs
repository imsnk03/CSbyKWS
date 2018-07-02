using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep8_Array
	{
		public static void ArrayMain()
		{
			// Initialize and assign values in different lines
			int[] EvenNumbers = new int[5];
			EvenNumbers[0] = 2;
			EvenNumbers[1] = 4;
			EvenNumbers[2] = 6;
			Console.WriteLine(EvenNumbers[2]);

			Console.WriteLine(" ");
			// Initialize and assign values in the same line
			int[] OddNumbers = { 3, 5, 7 };
			Console.WriteLine(OddNumbers[2]);

			Console.WriteLine(" ");
			int[] Numbers = { 1, 2, 3, 4, 5, 6 };
			for (int i = 0; i < Numbers.Length ; ++i )
			{
				Console.WriteLine(Numbers[i]);
			}

			Console.ReadKey();

		}
	}
}
