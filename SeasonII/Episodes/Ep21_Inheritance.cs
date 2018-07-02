using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonII.Episodes
{
	public class InheritanceMainClass {
		public static void InhertinanceMainMethod() {
			InheritanceEx1.Ep21_Inheritance.InheritanceMethodEx1();
			InheritanceEx2.Ep21_Inheritance.InheritanceMethodEx2(); ;
		}
	}
}


namespace InheritanceEx1
{
	public class Empployee {
		public string FirstName;
		public string LastName;
		public string Email;
		public void PrintFullName() {
			Console.Write(FirstName+""+LastName);
		}
	}

	public class FullTimeEmployee : Empployee {
		public float YearlySalary;
	}

	public class PartTimeEmployee : Empployee {
		public float HourlyRate;
	}

	class Ep21_Inheritance {
		public static void InheritanceMethodEx1() {
			FullTimeEmployee FTE = new FullTimeEmployee();
			FTE.FirstName = "Shiv";
			FTE.LastName = "Nag ";
			FTE.YearlySalary = 5000;
			FTE.PrintFullName();
			Console.WriteLine(FTE.YearlySalary);
			

			PartTimeEmployee PTE = new PartTimeEmployee();
			PTE.FirstName = "Me";
			PTE.LastName = "nU ";
			PTE.HourlyRate = 500;
			PTE.PrintFullName();
			Console.WriteLine(PTE.HourlyRate);
			Console.ReadKey();
		}
	}
}

//Parent Class Constructor Executes  before Child Class Constructor
namespace InheritanceEx2
{
	public class ParentClass {
		public ParentClass() {
			Console.WriteLine("Parent Class Constructor Called");
		}
		/*
		public ParentClass(string Message)
		{
			Console.WriteLine(Message);
		}
		*/
	}

	public class ChildClass : ParentClass
	{
		public ChildClass() 
		{
			Console.WriteLine("Child Class Constructor is called");
		}
		/*
		 *public ChildClass() : base("this is message")
			{
				Console.WriteLine("Child Class Constructor is called");
			}
		*/
	}

	class Ep21_Inheritance {
		public static void InheritanceMethodEx2() {
			ChildClass CC = new ChildClass();
			Console.ReadKey();
		}
	}
}


/*
class A { }
class B { } : class A
class C { } : class B

If we create a class C object then class A,B properties also inherited 
*/