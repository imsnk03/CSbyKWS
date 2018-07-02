using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonII.Episodes
{
	class Ep22_MethodHiding
	{


		public class Employee
		{
			public void Print()
			{
				Console.WriteLine("Im a Employee Class");
			}
		}

		public class PartTimeEmployee : Employee
		{
			public void Print()
			{
				Console.WriteLine("Im Part time Employee");
			}
		}


		public static void MethodHidingMain()
		{
			PartTimeEmployee PTE = new PartTimeEmployee();
			PTE.Print();
			Console.ReadKey();
		}
		 
	}
}
