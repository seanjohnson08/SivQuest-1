using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivQuest
{
    class Program
    {

        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            Flags flags = new Flags();
            Text text = new Text(flags);
            string input;
            string[] gargs;
            writer.writeHeading("   SivQuest");
            writer.write(text.welcome);

            while (true)
            {
                input = writer.getInput().ToUpper().Trim();
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
                        writer.write(String.format("UNKNOWN COMMAND: {0}", input));
                        break;
                }

            }
        }
    }
}
