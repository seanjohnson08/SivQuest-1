using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace SivQuest
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "SivQuest";
            Console.WindowWidth = 80;
            Console.BufferWidth = 80;
            Console.WindowHeight = 25;
            Console.BufferHeight = 25;
            Flags flags = new Flags();
            Text text = new Text(flags);
            string input;
            string[] gargs;
            Console.WriteAscii("   SivQuest", Color.LightBlue);
            text.write(text.welcome);

            //Console.Clear();
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
