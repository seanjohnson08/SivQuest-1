using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivQuest
{
    public class Text
    {
        private Flags flags;
        
        public Text(Flags flags)
        {
            this.flags = flags;
        }
        public string welcome = "Welcome to SivQuest\n";
        public string story = "A very long story.";

    }
}
