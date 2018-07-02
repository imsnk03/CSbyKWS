using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeasonI.Episodes;

namespace SeasonI
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ep1_Introduction.IntroductionMain();
			//Ep2_ReadingWritingToConsole.ReadingWritingToConsoleMain();
			//Ep6_NullableType.NullableTypeMain();
			//Ep7_DataTypeConverstions.DataTypeConversionMain();
			//Ep8_Array.ArrayMain();
			//Ep10_IFstatement.IFstatementMain();
			//Ep11_Switch1.Switc1hMain();
			//Ep12_Switch2.Switch2Main();
			//Ep13_While.WhileMain();
			//Ep14_DoWhile.DoWhileMain();
			//Ep15_ForForEach.ForForEachMain();
			//Ep16_Methods.MethodsMain();
			//Ep17_MethodParameers.MethodParameterMain();
			//Ep18_NameSpaces.NameSpacesMain();
		}
	}
}



/*
	class Program2
	{
		public static void Main2()
			{

			IList<Student> studentList = new List<Student>() {
								new Student(){ StudentID=1, StudentName="Windows"},
								new Student(){ StudentID=2, StudentName="Dvd"},
								new Student(){ StudentID=3, StudentName="Intel"},
								new Student(){ StudentID=4, StudentName="Dell"}
						};

			//var search = studentList[2];
			var copiedList = studentList.ToList();
			studentList.RemoveAt(2);
			//studentList.Insert(1, copiedList[2]);

			Console.WriteLine("Deleted List\n");
			foreach (var item in studentList)
				Console.WriteLine(item.StudentID + "=>" + item.StudentName);

			Console.WriteLine("\n\nBelow is copy of original list\n");
			foreach (var item in copiedList)
				Console.WriteLine(item.StudentID + "=>" + item.StudentName);
	
			Console.ReadKey();
		}
	}


	public class Student	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
	}

	*/