using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivQuest
{

    class Program
    {
        
        static void text(string text,)
        {
            Console.Write("");

        }

        static void Main(string[] args)
        {
            Console.Clear();
      		Player player = new Player();
			player.name = "foo";
            string input;
			string[] gargs;

            Console.Write("Welcome to SivQuest.\nPlease type your name: ");
            input = Console.ReadLine();
			player.name = input;
			Console.Clear();
			//Console.ForegroundColor = ;
			Console.WriteLine("You ");
            while (true)
            {
                
				input = Console.ReadLine().ToUpper().Trim();
                gargs = input.Split(' ');
                switch (input)
                {
                    case "NORTH":
                    case "SOUTH":
                    case "EAST":
                    case "WEST":
                        break;

					case "HELP":
						break;


						


                    default:
                        Console.WriteLine("UNKNOWN COMMAND: {0}",input);
                        break;


                }

            }
        }
    }
}
