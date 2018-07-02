using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonII.Episodes
{

	class Circle
	{

		static float _pi;
		int _radius;

		static Circle()
		{
			Console.WriteLine("This is first called 1");
			Circle._pi = 3.143F;
		}

		public Circle(int Radius)
		{
			this._radius = Radius;
		}

		public float Print()
		{
			return _pi * _radius * _radius;
		}
	}


	class Ep20_StaticInstanceClass
	{
		public static void StaticInstanceClassMain()
		{
			Circle C1 = new Circle(5);
			Console.WriteLine(C1.Print());

			Circle C2 = new Circle(6);
			Console.WriteLine(C2.Print());
			Console.ReadKey();

		}
	}
}
