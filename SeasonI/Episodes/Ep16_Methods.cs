using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI
{
	class Ep16_Methods
	{

		public static void MethodsMain()
		{
			Ep16_Methods obj = new Ep16_Methods();
			int Sum = obj.Add(5,4);
			Console.WriteLine("Sum of 5+4: "+Sum);
			Console.WriteLine("");
			StaticMethod(30);
		}


		//This is an instance menthod invoked by instacne of class
		public int Add(int var1, int var2)
		{
			return var1 + var2;
		}


		//This is static method and return type is void
		public static void StaticMethod(int Target)
		{
			int Start = 0;
			for (int i=0; Start <=Target; ++i)
			{
				Console.Write(Start+" ");
				Start = Start + 2;
			}
			Console.ReadKey();
		}

	}
}
