using System.Drawing;

namespace SivQuest {  
  interface IWriter {
      string getInput();
      void write(string text);
      void writeHeading(string text);
  }
}