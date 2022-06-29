using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp4
{

	class Fish
	{
		public Fish(string f)
        {
			fish = f;
        }
		string fish { get; set; }
		int size { get; set; }

	}
	class Program
	{
		class Game
		{
			int point;
			string[] fi;
			string[] fishE;
			List<Fish> f = new List<Fish>();
			string vvod = "";
			int x = 1;
			Random r = new Random(DateTime.Now.Millisecond);
			public Game()
			{
				point = 0;
				fi = new string[] { "s", "m", "b", " " };
				fishE = new string[] { "M", "B", " " };
				f.Add(new Fish(fi[r.Next(fi.Length)]));
			}

			public void PlaceFish()
			{
				Console.WriteLine(fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)]);
				Console.WriteLine(fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)]);
				Console.WriteLine(fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)]);
				Console.WriteLine(fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)]);
				Console.WriteLine(fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)] + " \t| " + fish[r.Next(fish.Length)]);

			}
		}
		static void Main(string[] args)
		{
			string vvod = "";
			int x = 1;
			Game game = new Game();
			game.PlaceFish();

			while (x != 0)
			{
				Console.WriteLine("0 - Exit");
				Console.Write("Write menu__ ");
				vvod = Console.ReadLine();
				x = Convert.ToInt32(vvod);




				if (x == 0)
				{
					Console.WriteLine("Write 1 - Back | Write 0 - Exit");
					vvod = Console.ReadLine();
					x = Convert.ToInt32(vvod);
					if (x == 0)
					{
						Console.WriteLine("GOODBAYE!");
						break;
					}


				}
			}
		}
	}
}





