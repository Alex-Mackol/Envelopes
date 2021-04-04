using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEnvelope.View
{
    class DisplayResultComparable
    {
        Display display;
        public DisplayResultComparable()
        {
            display = new Display();
        }

        public void DisplayResultAfterComparable(int resultComparable)
        {
            if (resultComparable == 0)
            {
                display.DisplayMessage("Noone envelope can be invested in each other!");
            }
            else if (resultComparable == 1)
            {
                display.DisplayMessage("Envelope2 can be invested in envelope1!");
            }
            else
            {
                display.DisplayMessage("Envelope1 and envelope2 can be invested in each other!");
            }
        }
    }
}
