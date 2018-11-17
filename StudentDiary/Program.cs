using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
	class Program
	{
		static void Main(string[] args)
		{
			Diary diary = new Diary();
			//diary.AddRating(5);
			//diary.AddRating(8.5f);
			//diary.AddRating(4.7f);
			//diary.AddRating(1.8f);

			//float avg = diary.CalcAverage();
			//float max = diary.GiveMaxRating();
			//float min = diary.GiveMinRating();

			for (; ; )
			{
				Console.WriteLine("podaj ocene z zakresu 1 -10 ");
				float rating;
				bool result = float.TryParse(Console.ReadLine(), out rating);

				if (rating == 11)
				{
					break;
				}
				if (result)
				{
					if (rating > 0 && rating <= 10)
					{
						diary.AddRating(rating);

					}
					else
					{
						Console.WriteLine("podaj liczbe z prawidlowego zakresu");
					}
				}
				if (result == false)
				{
					Console.WriteLine("ma byc liczba!");
				}
			}

			Console.WriteLine("średnia = " + diary.CalcAverage());
			Console.WriteLine("max = " + diary.GiveMaxRating());
			Console.WriteLine("min = " + diary.GiveMinRating());
			Console.ReadKey();
		}
	}
}
