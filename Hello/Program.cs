using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
	class Program
	{

		static void Main(string[] args)
		{
			ValueTypes();
			Greeting();
			for (; ; )
			{
				Age();
			}

		}

		private static void ValueTypes()
		{
			int maxInt = int.MaxValue;
			int minInt = int.MinValue;
			long maxLong = long.MaxValue;
			long minLong = long.MinValue;
			Console.WriteLine("maxInt = " + maxInt);
			Console.WriteLine("minInt = " + minInt);
			Console.WriteLine("maxLong = " + maxLong);
			Console.WriteLine("minLong = " + minLong);
		}

		/// <summary>
		/// komunikat zależny od wieku
		/// </summary>
		private static void Age()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("ile masz lat? ");
			int age;
			bool result = int.TryParse(Console.ReadLine(), out age);

			if (age < 18 && age > 0)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("za mlody");
			}
			else if (result == false)
			{
				Console.WriteLine("podaj poprawny wiek");
			}
			else
			{
				Console.WriteLine("ok!");
			}
			Console.WriteLine("nacisnij dowolny klawisz");
			Console.ReadKey();
			Console.Clear();
		}
		/// <summary>
		/// Wypisanie powitania
		/// </summary>
		private static void Greeting()
		{
			Console.Write("wpisz swoje imie ");
			string name = Console.ReadLine();
			Console.WriteLine("Witaj " + name);
		}
	}
}
