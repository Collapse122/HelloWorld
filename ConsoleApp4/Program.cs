using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp4
{

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
				Console.WriteLine(fish[r.Next(fish.Length)]+ " | " + fish[r.Next(fish.Length)] + " | " );
            }
		}

        static void Main(string[] args)
		{

		}
	}


}

