using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep14_DoWhile
	{
		public static void DoWhileMain()
		{
			string UserChoice;
			do
			{
				Console.Write("Please enter a number target: ");
				int UserTarget = int.Parse(Console.ReadLine());
				int Start = 0;

				do
				{
					Console.Write(Start + " ");
					Start = Start + 2;
				} while (Start <= UserTarget);


				Console.WriteLine(" Terminate the Program Yes | No");
				UserChoice = Console.ReadLine().ToUpper();

				do
				{
					if (UserChoice != "YES" && UserChoice != "NO")
						Console.Write("Please give an valid answer: ");

				} while (UserChoice != "YES" && UserChoice != "NO");

			} while (UserChoice == "NO");

			Console.ReadKey();

		}
	}
}
