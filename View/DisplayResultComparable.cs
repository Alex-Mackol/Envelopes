using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEnvelope.View
{
    class DisplayResultComparable
    {
        public Display Display { get; }
        public DisplayResultComparable(Display display)
        {
            Display = display;
        }

        public void DisplayResultAfterComparable(int resultComparable)
        {
            if (resultComparable == 0)
            {
                Display.DisplayMessage("Noone envelope can be invested in each other!");
            }
            else if (resultComparable == 1)
            {
                Display.DisplayMessage("Envelope2 can be invested in envelope1!");
            }
            else
            {
                Display.DisplayMessage("Envelope1 and envelope2 can be invested in each other!");
            }
        }
    }
}
