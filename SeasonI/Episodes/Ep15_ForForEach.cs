using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep15_ForForEach
	{
		public static void ForForEachMain()
		{
			ForMethod();
			ForEachMethod();
			BreakContinue();
		}

		public static void ForMethod()
		{
			int[] ArrayOfNumbers = { 101, 102, 103 };

			for(int i = 0; i<=2;++i)
				Console.Write(ArrayOfNumbers[i]+" ");
			Console.ReadKey();
		}


		//Is used for Collections in single line
		public static void ForEachMethod()
		{
			int[] ArrayOfNumber = new int[4];
			ArrayOfNumber[0] = 2;
			ArrayOfNumber[1] = 4;
			ArrayOfNumber[3] = 6;

			foreach(int number in ArrayOfNumber)
			{
				Console.Write(number + " ");
			}
			Console.ReadKey();
		}


		public static void BreakContinue()
		{
			Console.WriteLine("Below Code Prints Break   \n");
			for (int i = 0; i <= 20; ++i)
			{
				if (i == 10)
					break;
				Console.Write(i + " ");
			}
			Console.WriteLine("\nBelow Code Prints  Continue \n");
			for (int i =0; i <= 20; ++i)
			{
			
				if (i % 2 == 1)
					continue;
				Console.Write(i + " ");
			}
			Console.ReadKey();
		}
	}
}
