using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEnvelope.View
{
    class DisplayInputEnvelope
    {
        Display display;
        public DisplayInputEnvelope()
        {
            display = new Display();
        }

        public void GetStringForEnvelope(out string widthEnvelope1, out string heigthEnvelope1, out string widthEnvelope2, out string heigthEnvelope2)
        {
            display.DisplayMessage("Enter width for first envelope:");
            widthEnvelope1 = Console.ReadLine();

            display.DisplayMessage("Enter heigth for first envelope:");
            heigthEnvelope1 = Console.ReadLine();

            display.DisplayMessage("Enter width for second envelope:");
            widthEnvelope2 = Console.ReadLine();

            display.DisplayMessage("Enter heigth for second envelope:");
            heigthEnvelope2 = Console.ReadLine();
        }
    }
}
