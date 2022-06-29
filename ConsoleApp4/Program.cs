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
			int x = 1;
			Random r = new Random(DateTime.Now.Millisecond);
			public Game()
			{
				point = 0;
				fi = new string[] { "s", "m", "b", " " };
				fishE = new string[] { "M", "B", "X" };
				for(int i = 0; i < 4; i++)
                {
					f.Add(new Fish(fi[i]));
				}
			}

			public void Level1()
			{
				Console.WriteLine("Level 1:" + "\t\tPoints - " + point);
				Console.WriteLine(" | " + f[0].name + " \t| " + " \t| " + f[1].name + " \t| " + " \t| " + f[2].name);
				Console.WriteLine();

			}
			public void Level2()
            {
				Console.WriteLine("Level 2:" + "\t\tPoints - " + point);
				Console.WriteLine(" | " + f[1].name + " \t| " + " \t| " + " \t| "   + f[2].name + " \t| " );
				Console.WriteLine(" | " + " \t| "   + " \t| " + " \t| " + f[0].name + " \t| ");
				Console.WriteLine();

			}
			public void Eat()
            {
				if(f[0].size <= 2)
                {
					if (f[0].name == "sm")
					{
						f[0].name = fishE[0];
					}
				}
				else
                {
					f[0].name = fishE[3];
                }
			
            }
		}
		static void Main(string[] args)
		{
			string vvod = "";
			int x = 1;
			Game game = new Game();
			game.Level1();
			game.Level2();

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





