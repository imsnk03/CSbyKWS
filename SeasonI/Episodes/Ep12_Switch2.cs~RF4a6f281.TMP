using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep12_Switch2
	{
		public static void	Switch2Main()
		{

			int TotalBillCost = 0;
			Start:
			Console.Write("Please enter a size 1-Small 2-Medium 3-Large: ");
			int UserChoice = int.Parse(Console.ReadLine());

			switch(UserChoice)
			{
				case 1:
					TotalBillCost += 1;
					break;
				case 2:
					TotalBillCost += 2;
					break;
				case 3:
					TotalBillCost += 3;
					break;
				default:
					Console.WriteLine("Plese Enter a Vaid input");
					goto Start;					
			}

			Response:
			Console.Write("Do you want to another Yes or No: ");
			string UserDescision = Console.ReadLine();

			switch(UserDescision.ToUpper())
			{
				case ("YES"):
					goto Start;
				case ("NO"):
					Console.WriteLine("Thanks for shopping");
					break;
				default:
					goto Response;					
			}
			Console.WriteLine("Bill to be paid is {0}",TotalBillCost);

			Console.ReadKey();

		}
	}
}
