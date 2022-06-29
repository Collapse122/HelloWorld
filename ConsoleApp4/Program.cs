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
		string fish { get; set; }
		int size { get; set; }

    }
	class Program
	{
		class Game
		{
			int point;
			string[] fish;

			string vvod = "";
			int x = 1;

			public Game()
			{
				point = 0;
				fish = new string[] { "small", "medium", "big" };
			}

			public void PlaceFish()
			{
				Random r = new Random();
			
				Console.WriteLine(fish[r.Next(fish.Length)] + " | " + fish[r.Next(fish.Length)] + " | ");
			}
			//Console.WriteLine(fish[r.Next(fish.Length)]+ " | " + fish[r.Next(fish.Length)] + " | ");
		}
		static void Main(string[] args)
		{
			string vvod = "";
			int x = 1;

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





