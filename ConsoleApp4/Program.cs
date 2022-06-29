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

		static void Main(string[] args)
		{

			string vvod = "";
			int x = 1;

			while(x!=0)
            {
				Console.WriteLine("0 - Exit");
				


				if(x == 0)
                {
					Console.WriteLine("Write 1 - Back | Write 0 - Exit");
					vvod = Console.ReadLine();
					x = Convert.ToInt32(vvod);
					if(x == 0)
                    {
						Console.WriteLine("GOODBAYE!");
						break;
                    }
                    

                }
            }
			

		}
	}


}

