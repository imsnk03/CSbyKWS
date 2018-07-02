using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace SeasonI.Episodes
{
	class Ep17_MethodParameers
	{
		public static void MethodParameterMain()
		{
			//ValueParameter.ValueParameterMain();
			//ReferenceParameter.referenceParameter();
			//OutParameter.outParameter();
			ParameterArrays.parameterArrays();
			Console.ReadKey();
		}



		class ValueParameter
		{
			public static void ValueParameterMain()
			{
				int var1 = 10;
				ValueParamMethod(var1);
				Console.WriteLine("Value Parameter =>"+var1);
			}

			public static void ValueParamMethod(int catchVar1)
			{
				catchVar1 = 33;
			}
		}


		class ReferenceParameter
		{
			public static void referenceParameter()
			{
				int var2 = 20;
				referenceParamMethod(ref var2);
				Console.WriteLine("Reference Parameter =>" + var2);
				

			}

			public static int referenceParamMethod(ref int catchVar2)
			{
				return catchVar2 = 46;
			}
		}


		class OutParameter
		{
			public static void outParameter()
			{
				int var1 = 10;
				int var2 = 23;
				int sum, mul;
				outParameterMethod(var1, var2, out sum, out mul);
				Console.WriteLine("Out Parameter Sum ,Mul=>" + sum +","+ mul);
			}

			public static void outParameterMethod(int var1, int var2, out int sum, out int mul)
			{
				sum = var2 + var1;
				mul = var1 * var1;
			}
		}


		class ParameterArrays
		{
			public static void parameterArrays()
			{
				int[] Numbers = { 101, 102, 103 };

				//parameterArraysMethod();
				parameterArraysMethod(Numbers);
				//parameterArraysMethod(1, 2, 3, 4, 5);
			}

			public static void parameterArraysMethod(params int[] Numbers)
			{
				Console.WriteLine("There are {0} elemnts",Numbers.Length);
				foreach(var i in Numbers)
					Console.Write(i+",");
			}

		}
	}
}


 