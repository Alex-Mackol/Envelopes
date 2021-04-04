using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskEnvelope.Interfaces;

namespace TaskEnvelope.View
{
    class DisplayToContinueProgram : IPrintToContinue
    {
       public Display Display { get; }
        string toContinue;
        public DisplayToContinueProgram(Display display)
        {
            Display = display;
        }
        public bool ToContinue()
        {
            Display.DisplayMessage("Do you want to input one more triangle ? (y / yes)");
            toContinue = Console.ReadLine();
            return (toContinue.Equals("y", StringComparison.InvariantCultureIgnoreCase) ||
                  toContinue.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
