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
			public string[] level1 = new string[25]; 
			public int levelup {get;set;}

			int x = 1;
			Random r = new Random(DateTime.Now.Millisecond);
			public Game()
			{
				point = 0;
				fi = new string[] { "s", "m", "b", " " };
				fishE = new string[] { "M", "B", "X" };
				for(int i = 0; i < 25; i++)
                {
					//f.Add(new Fish(fi[i]));
					f.Add(new Fish(fi[r.Next(4)]));
				}
		    }
			
			public void PrepareLevel1()
            {
				for(int i = 0;i<25;i++)
                {
					level1[i] = f[i].name;
                }
            }
			public void Level1()
			{
				Console.WriteLine("Введіть номер рибки від 1 - 5");
				Console.WriteLine("Рівень 1:" + "\t\tОчки - " + point);
				Console.WriteLine(" | " + level1[0] + " \t| " + level1[1] + " | " + level1[2]  + " \t| " + level1[3] + " | " + level1[4] + "    | ");
				Console.WriteLine();
			}
			public void Level2()
            {
				Console.WriteLine("Введіть номер рибки від 1 - 10");
				Console.WriteLine("Рівень 2:" + "\t\tОчки - " + point);
				Console.WriteLine(" | " + level1[0] + " \t| " + level1[1] + " | " + level1[2] + " \t| " + level1[3] + " | " + level1[4] + "    | ");
				Console.WriteLine(" | " + level1[5] + " \t| " + level1[6] + " | " + level1[7] + " \t| " + level1[8] + " | " + level1[9] + "    | ");
				Console.WriteLine();

			}
			public void Level3()
            {
				Console.WriteLine("Введіть номер рибки від 1 - 15");
				Console.WriteLine("Рівень 3:" + "\t\tОчки - " + point);
				Console.WriteLine(" | " + level1[0] + " \t| " + level1[1] + " | " + level1[2] + " \t| " + level1[3] + " | " + level1[4] + "    | ");
				Console.WriteLine(" | " + level1[5] + " \t| " + level1[6] + " | " + level1[7] + " \t| " + level1[8] + " | " + level1[9] + "    | ");
				Console.WriteLine(" | " + level1[10] + " \t| " + level1[11] + " | " + level1[12] + " \t| " + level1[13] + " | " + level1[14] + "    | ");
				Console.WriteLine();
			}
			public void Level4()
            {
				Console.WriteLine("Введіть номер рибки від 1 - 20");
				Console.WriteLine("Рівень 4:" + "\t\tОчки - " + point);
				Console.WriteLine(" | " + level1[0] + " \t| " + level1[1] + " | " + level1[2] + " \t| " + level1[3] + " | " + level1[4] + "    | ");
				Console.WriteLine(" | " + level1[5] + " \t| " + level1[6] + " | " + level1[7] + " \t| " + level1[8] + " | " + level1[9] + "    | ");
				Console.WriteLine(" | " + level1[10] + " \t| " + level1[11] + " | " + level1[12] + " \t| " + level1[13] + " | " + level1[14] + "    | ");
				Console.WriteLine(" | " + level1[15] + " \t| " + level1[16] + " | " + level1[17] + " \t| " + level1[18] + " | " + level1[19] + "    | ");
				Console.WriteLine();
			}
			public void Level5()
			{
				Console.WriteLine("Введіть номер рибки від 1 - 25");
				Console.WriteLine("Рівень 4:" + "\t\tОчки - " + point);
				Console.WriteLine(" | " + level1[0] + " \t| " + level1[1] + " | " + level1[2] + " \t| " + level1[3] + " | " + level1[4] + "    | ");
				Console.WriteLine(" | " + level1[5] + " \t| " + level1[6] + " | " + level1[7] + " \t| " + level1[8] + " | " + level1[9] + "    | ");
				Console.WriteLine(" | " + level1[10] + " \t| " + level1[11] + " | " + level1[12] + " \t| " + level1[13] + " | " + level1[14] + "    | ");
				Console.WriteLine(" | " + level1[15] + " \t| " + level1[16] + " | " + level1[17] + " \t| " + level1[18] + " | " + level1[19] + "    | ");
				Console.WriteLine(" | " + level1[20] + " \t| " + level1[21] + " | " + level1[22] + " \t| " + level1[23] + " | " + level1[24] + "    | ");
				Console.WriteLine();
			}
			public void Eat(int num1,int num2)
            {

				int temp = 0;

				if (level1[num1] == level1[num2])
                {
					Console.WriteLine("Не можу з'їсти цю рибку, одинаковий розмір!");
                }
				else if (level1[num1] == "s")
                {
					Console.WriteLine("Не можу з'їсти нікого бо я найменша рибка!");
				}
				else if ((level1[num1] == "m" || level1[num1] == "M") && level1[num2] == "b")
                {
					Console.WriteLine("Середня рибка не може з'їсти велику!");
				}
				else if (level1[num1] == " ")
                {
					Console.WriteLine("Пуста клітинка не може їсти інших!");
				}
				else if (level1[num2] == " ")
				{
					Console.WriteLine("Не можу з'їсти пусту клітинку!");
				}
                else
                {
					if(level1[num1] == "m")
                    {
						level1[num1] = fishE[0];
					}
					else if(level1[num1] == "b")
                    {
						level1[num1] = fishE[1];
					}
					level1[num2] = " ";
                    if (f[num1].size == 2)
                    {
						level1[num1] = " ";
                    }
					point++;
					Console.WriteLine("\tРибка " + level1[num1] + " " + "поїла ");
					point += 30;
                }

			}
		}
		static void Main(string[] args)
		{


			Console.OutputEncoding = UTF8Encoding.UTF8;

			string vvod = "";
			int x = 1;
			Game game = new Game();
			Console.WriteLine("\t\tGame Fish eater");

			List<Fish> MyFish;
			while (x != 0)
			{
				Console.WriteLine("\tВиберіть пункт меню ");
				Console.WriteLine("0 - Вихід");
				Console.WriteLine("1 - Почати гру");
				vvod = Console.ReadLine();
				x = Convert.ToInt32(vvod);

				if(x == 1)
                {
					while (x != 5)
					{
						Console.WriteLine("\t\tОберіть рівень гри:");
						Console.WriteLine("1 - перший рівень");
						Console.WriteLine("2 - другий рівень");
						Console.WriteLine("3 - третій рівень");
						Console.WriteLine("4 - четвертий рівень");
						Console.WriteLine("5 - п'ятий рівень");
						int choice_level = int.Parse(Console.ReadLine());
						int ribka1 = 0;
						int ribka2 = 0;
						if (choice_level == 1)
						{
							game.PrepareLevel1();
							game.Level1();
							int turn = 0;
							string[] lvl1 = new string[] { " ", "\t", " ", "\t", "B" };
							do
							{
								Console.WriteLine("Хід - " + turn);
								Console.WriteLine("0 - Вихід з гри");
								Console.WriteLine("Виберіть рибку яка буде їсти (оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka1 = Convert.ToInt32(vvod);
								if (vvod == "0")
								{
									break;
								}
								Console.WriteLine("Виберіть рибку яку з'їдять(оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka2 = Convert.ToInt32(vvod);

								game.Eat(ribka1 - 1, ribka2 - 1);
								turn++;
								game.Level1();
								if (game.level1.Equals(lvl1))
								{
									Console.WriteLine("Рівень пройдено!");
									break;
								}
								
							} while (turn < 5);


						}
						else if (choice_level == 2)
						{
							game.PrepareLevel1();
							game.Level2();
							int turn = 0;
							string[] lvl1 = new string[] { " ", "\t", " ", "\t", "B" };
							do
							{
								Console.WriteLine("Хід - " + turn);
								Console.WriteLine("0 - Вихід з гри");
								Console.WriteLine("Виберіть рибку яка буде їсти (оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka1 = Convert.ToInt32(vvod);
								if (vvod == "0")
								{
									break;
								}
								Console.WriteLine("Виберіть рибку яку з'їдять(оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka2 = Convert.ToInt32(vvod);

								game.Eat(ribka1 - 1, ribka2 - 1);
								turn++;
								game.Level2();
								if (game.level1.Equals(lvl1))
								{
									Console.WriteLine("Рівень пройдено!");
									break;
								}

							} while (turn < 5);


						}
						else if (choice_level == 3)
						{
							game.PrepareLevel1();
							game.Level3();
							int turn = 0;
							string[] lvl1 = new string[] { " ", "\t", " ", "\t", "B" };
							do
							{
								Console.WriteLine("Хід - " + turn);
								Console.WriteLine("0 - Вихід з гри");
								Console.WriteLine("Виберіть рибку яка буде їсти (оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka1 = Convert.ToInt32(vvod);
								if (vvod == "0")
								{
									break;
								}
								Console.WriteLine("Виберіть рибку яку з'їдять(оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka2 = Convert.ToInt32(vvod);

								game.Eat(ribka1 - 1, ribka2 - 1);
								turn++;
								game.Level3();
								if (game.level1.Equals(lvl1))
								{
									Console.WriteLine("Рівень пройдено!");
									break;
								}

							} while (turn < 5);


						}
						else if (choice_level == 4)
						{
							game.PrepareLevel1();
							game.Level4();
							int turn = 0;
							string[] lvl1 = new string[] { " ", "\t", " ", "\t", "B" };
							do
							{
								Console.WriteLine("Хід - " + turn);
								Console.WriteLine("0 - Вихід з гри");
								Console.WriteLine("Виберіть рибку яка буде їсти (оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka1 = Convert.ToInt32(vvod);
								if (vvod == "0")
								{
									break;
								}
								Console.WriteLine("Виберіть рибку яку з'їдять(оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka2 = Convert.ToInt32(vvod);

								game.Eat(ribka1 - 1, ribka2 - 1);
								turn++;
								game.Level4();
								if (game.level1.Equals(lvl1))
								{
									Console.WriteLine("Рівень пройдено!");
									break;
								}

							} while (turn < 5);


						}
						else if (choice_level == 5)
						{
							game.PrepareLevel1();
							game.Level5();
							int turn = 0;
							string[] lvl1 = new string[] { " ", "\t", " ", "\t", "B" };
							do
							{
								Console.WriteLine("Хід - " + turn);
								Console.WriteLine("0 - Вихід з гри");
								Console.WriteLine("Виберіть рибку яка буде їсти (оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka1 = Convert.ToInt32(vvod);
								if (vvod == "0")
								{
									break;
								}
								Console.WriteLine("Виберіть рибку яку з'їдять(оберіть клітинку на якій вона стоїть)");
								vvod = Console.ReadLine();
								ribka2 = Convert.ToInt32(vvod);

								game.Eat(ribka1 - 1, ribka2 - 1);
								turn++;
								game.Level5();
								if (game.level1.Equals(lvl1))
								{
									Console.WriteLine("Рівень пройдено!");
									break;
								}

							} while (turn < 5);


						}
                        else
                        {
							Console.WriteLine("ERROR!!!");
							break;
                        }
				

					}

					x = 0;
                }
				else if (x == 0)
				{
					Console.WriteLine("Напишіть 1 - Повернутись | Напишіть 0 - Вийти");
					vvod = Console.ReadLine();
					x = Convert.ToInt32(vvod);
					if (x == 0)
					{
						Console.WriteLine("До побачення!");
						break;
					}
				}
				else
                {
					Console.WriteLine("Помилка вибору меню!");
					x = 1;
                }
			}
		}
	}
}





