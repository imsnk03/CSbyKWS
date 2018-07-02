using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep13_While
	{

		public static void WhileMain()
		{
			Console.WriteLine("Please enter a number target");
			int UserNumber = int.Parse(Console.ReadLine());

			int Start = 0;
			while(Start <= UserNumber)
			{
				Console.Write(Start + " ");
				Start = Start + 2;
				
			}

			Console.ReadKey();
		}

	}
}
