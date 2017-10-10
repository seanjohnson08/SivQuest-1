using Colorful;
using System.Drawing;
using Console = Colorful.Console;

namespace SivQuest
{
    public class ConsoleWriter : IWriter {
        public ConsoleWriter() {
            Console.Clear();
            Console.Title = "SivQuest";
            Console.WindowWidth = 80;
            Console.BufferWidth = 80;
            Console.WindowHeight = 25;
            Console.BufferHeight = 25;
        }
        public string getInput() {
            return Console.ReadLine();
        }
        public void write(string text) {
            StyleSheet styleSheet = new StyleSheet(Color.White);
            styleSheet.AddStyle("SivQuest", Color.MediumSlateBlue);
            Console.WriteStyled(text, Color.Gray,styleSheet);
        }
        public void writeHeading(string headingText) {
            Console.WriteAscii(headingText);
        }
    }
}