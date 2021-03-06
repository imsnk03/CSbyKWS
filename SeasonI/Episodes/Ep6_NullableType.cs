﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonI.Episodes
{
    class Ep6_NullableType
    {
		public static void NullableTypeMain()
		{
			SampleNullable();
			WithoutCoalescing();
			WithCoalescing();
		}

		public static void SampleNullable()
		{
			bool? AreYouMajor = true;

			if (AreYouMajor == true)
				Console.WriteLine("User is Major");
			else if (!AreYouMajor.Value)
				Console.WriteLine("User is not major");
			else
				Console.WriteLine("User didnt answered");

			Console.ReadKey();
		}

		public static void WithoutCoalescing()
		{
			int? TicketsOnSale = null;
			int AvailbleTickets;
			if (TicketsOnSale == null)
				AvailbleTickets = 0;
			else
				//AvaialbleTickets = (int)TicketsOnSale;
				AvailbleTickets = TicketsOnSale.Value;

			Console.WriteLine("Tickets Available are{0}",AvailbleTickets);
			Console.ReadKey();
		}

		public static void WithCoalescing()
		{
			int? TicketsOnSale = null;
			int AvailableTickets = TicketsOnSale ?? 0;

			Console.WriteLine("Tickets Available are{0}", AvailableTickets);
			Console.ReadKey();
		}
		}
}
