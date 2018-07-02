using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
	class Ep2_ReadingWritingToConsole
	{
		public static void ReadingWritingToConsoleMain()
		{
			//This Concatination
			Console.Write("Please Enter Your Name: ");
			string name;
			name = Console.ReadLine();			
			Console.WriteLine("Hi" +name+". Im Nagendra");
			Console.WriteLine("");
			//This is place holder
			Console.WriteLine("Do you want learn C#");
			string response;
			response = Console.ReadLine();
			Console.WriteLine("So {0} Your response is {1}",name,response);

			Console.ReadLine();

		}
		
	}
}
