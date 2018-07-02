using System;
using ProjectA.TeamA;
//using ProjectA.TeamB;
//using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


namespace SeasonI.Episodes
{
	class Ep18_NameSpaces
	{
		public static void NameSpacesMain()
		{
			//Beloe is Fully qualified name and no need of adding any using directives of namespaces
			//ProjectA.TeamA.ClassA.MainClassA();
			//ProjectA.TeamB.ClassA.MainClassA();

			//Below gives a ambiguous so we have to use the name space alias 
			ClassA.MainClassA();
			//ClassA.MainClassA();

			//PATA.ClassA.MainClassA();
			PATB.ClassA.MainClassA();


			Console.ReadKey();
		}
	}
}

	namespace ProjectA
	{
		namespace TeamA
		{
			class ClassA
			{
				public static void MainClassA()
				{
					Console.WriteLine("Hi iam a class of TeamA");
				}
			}
		}

		namespace TeamB
		{
			class ClassA
			{
				public static void MainClassA()
				{
					Console.WriteLine("Hi iam a class of TeamB");
				}
			}
		}
	}



