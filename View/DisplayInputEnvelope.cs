using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEnvelope.View
{
    class DisplayInputEnvelope
    {
        public Display Display { get; }
        public DisplayInputEnvelope(Display display)
        {
            Display = display;
        }

        public void GetStringForEnvelope(out string widthEnvelope1, out string heigthEnvelope1, out string widthEnvelope2, out string heigthEnvelope2)
        {
            Display.DisplayMessage("Enter width for first envelope:");
            widthEnvelope1 = Console.ReadLine();

            Display.DisplayMessage("Enter heigth for first envelope:");
            heigthEnvelope1 = Console.ReadLine();

            Display.DisplayMessage("Enter width for second envelope:");
            widthEnvelope2 = Console.ReadLine();

            Display.DisplayMessage("Enter heigth for second envelope:");
            heigthEnvelope2 = Console.ReadLine();
        }
    }
}
