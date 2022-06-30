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

			public int levelup {get;set;}
			

			

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
			public void Eat(int num1,int num2)
            {
				int temp = 0;
				if (f[num1].name == f[num2].name)
                {
					Console.WriteLine("No Fish eat!");
                }
				else if (f[num1].name == "s" )
                {
					Console.WriteLine("No Fish eat!");
				}
				else if (f[num1].name == "m" && f[num2].name == "b")
                {
					Console.WriteLine("No Fish eat!");
				}
				else if (f[num1].name == " ")
                {
					Console.WriteLine("No Fish eat!");
				}
				else if (f[num2].name == " ")
				{
					Console.WriteLine("No Fish eat!");
				}
                else
                {
					f[num1].size++;
					f[num2].name = " ";
                    if (f[num1].size == 2)
                    {
						f[num1].name = " ";
						
                        for(int i = 0;i<3;i++)
                        {
                            if (f[i].name == " ")
                            {
								temp++;
                            }
                        }
                    }
					levelup += temp+1;
					Console.WriteLine("Fish eat");
                }

			}
		}
		static void Main(string[] args)
		{
			string vvod = "";
			int x = 1;
			Game game = new Game();
			game.Level1();
			//game.Level2();

			List<Fish> MyFish;
			while (x != 0)
			{
				Console.WriteLine("0 - Exit");
				Console.WriteLine("1 - Start Game");
				Console.Write("Write menu__ ");
				vvod = Console.ReadLine();
				x = Convert.ToInt32(vvod);



				if(x == 1)
                {

					
					while (x != 5)
					{

						int c = 0;
						if (game.levelup < 3)
						{
							game.Level1();
						}
						else if(game.levelup < 6 && game.levelup>=3) // Можна додати ще кілька рівнів  !!
                        {
							game.Level2();
                        }
						
						Console.WriteLine("5 - EXIT");
						Console.WriteLine("0  -  1 -  2");
						Console.WriteLine("Choose a fish that will eat");
						vvod = Console.ReadLine();
						x = Convert.ToInt32(vvod);
						Console.WriteLine("Сhoose a fish that will eat");
						vvod = Console.ReadLine();
						c = Convert.ToInt32(vvod);
						game.Eat(x, c);
						

						


					}

					x = 0;
                }
				else if (x == 0)
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
				else
                {
					Console.WriteLine("ERROR!");
					x = 1;
                }
			}
		}
	}
}





