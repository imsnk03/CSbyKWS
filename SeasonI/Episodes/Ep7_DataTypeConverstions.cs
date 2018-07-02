using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep7_DataTypeConverstions
	{
		public static void DataTypeConversionMain()
		{
			//Converting int to float which is done implicitly
			int var1 = 45;
			float var2 = var1;
			Console.WriteLine(var2);

			//Explicitly Converstion we are doing a type casting
			float var3 = 13689318431498.231F;
			int var4 = (int)var3;
			Console.WriteLine(var4);

			//Below cose through a excpetion ehich is overFlow 
			//int var5 = Convert.ToInt32(var3);
			//Console.WriteLine(var5);

			//We can use Parse or TryParse depending on the valid input 
			string var6 = "789";
			int var7 = int.Parse(var6);
			Console.WriteLine(var7);
			
			//If we perform like above for 789TX it says format exception
			string var8 = "789TX";
			int Result = 0;
			bool IsValid = int.TryParse(var8, out Result);
			if (IsValid)
				Console.WriteLine(var8);
			else
				Console.WriteLine("Please Enter a Valid number");


			Console.ReadKey();
		}
	}
}
