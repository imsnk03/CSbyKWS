using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep10_IFstatement
	{
		public static void IFstatementMain()
		{
			IfConditions();
			LogicalConditions();
		}

		public static void IfConditions()
		{
			Console.Write("Please Enter a number: ");
			int var1 = int.Parse(Console.ReadLine());

			//if(var1 == 1)
			//	Console.WriteLine("Entered Number is One");
			//if (var1 == 2)
			//	Console.WriteLine("Entered Number is Two");

			//From the above code below is more efficient
			if (var1 == 1)
				Console.WriteLine("Entered Number is One");
			else if(var1 == 2)
				Console.WriteLine("Entered Number is Two"); 
			else
				Console.WriteLine("Entered Number is more than two");

			Console.WriteLine("IfConditions Ends Here\n"	);
			Console.ReadKey();
		}

		public static void LogicalConditions()
		{
			Console.Write("Please Enter a number: ");
			int var1 = int.Parse(Console.ReadLine());

			//It Validates the both the condition even left is false
			if (var1 == 1 & var1 == 2)
			{
				Console.WriteLine("Entered number is 1 or 2 \n");
			}
			else
				Console.WriteLine("Entered Number is more than two\n");

			Console.WriteLine("Below One is Double End");
			//Short Circuit Evaluation
			if (var1 == 1 && var1 == 2)
			{
				Console.WriteLine("Entered number is 1 or 2");
			}
			else if (var1 == 1 || var1 == 2)
			{
				Console.WriteLine("Entered number is 1 or 2");
			}
			else
				Console.WriteLine("Entered Number is more than two");

			Console.ReadKey();
		}
	}
}
