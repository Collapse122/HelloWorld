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
		public string name;
		public int size;
		public Fish() { }
		public Fish(string f)
        {
			name = f;
        }
		string Fiish
		{ 
			get { return name; } 
			set { name = value; } 
		}
		int Size { get { return size; } set { size = value; } }

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
				for(int i = 0; i < 4; i++)
                {
					f.Add(new Fish(fi[r.Next(fi.Length)]));
				}
			}

			public void PlaceFish()
			{
				Console.WriteLine(" | " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name);
				Console.WriteLine(" | " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name);
				Console.WriteLine(" | " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name);
				Console.WriteLine(" | " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name);
				Console.WriteLine(" | " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name + " \t| " + f[r.Next(f.Count)].name);
			}
			
		}
		static void Main(string[] args)
		{
			string vvod = "";
			int x = 1;
			Game game = new Game();
			game.PlaceFish();

			List<Fish> MyFish;
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





