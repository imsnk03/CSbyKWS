using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonII.Episodes
{
	class Customer
	{
		string _firstName, _lastName;

		public Customer() : this(" ", " ")
		{
		}

		public Customer(string FirstName, string LastName)
		{
			_firstName = FirstName;
			this._lastName = LastName;
		}

		public void Print()
		{
			Console.WriteLine("Given Data is :" + this._firstName + " " + _lastName);
		}

		~Customer() { }
	}



	class Ep19_ClassIntro
	{
		public static void ClassIntroMain()
		{

			//Customer C1 = new Customer();
			Customer C1 = new Customer("Shiva", "Nagendra");
			C1.Print();
			Console.ReadKey();
		}
	}
}
