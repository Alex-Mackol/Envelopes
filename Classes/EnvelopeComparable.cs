using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskEnvelope.Classes
{
    class EnvelopeComparable /*: IComparer<Envelope>*/
    {
        public int Compare(Envelope envelope1, Envelope envelope2)
        {
            int canBeInvested = 0;

            if (IfEnvelope2InsertinEnvelope1(envelope1,envelope2))
            {
                canBeInvested = 1;
            }
            if (IfEnvelope2InsertinEnvelope1(envelope2,envelope1))
            {
                canBeInvested += 2;
            }

            return canBeInvested;
        }

        private bool IfEnvelope2InsertinEnvelope1(Envelope envelope1, Envelope envelope2)
        {
            return (envelope1.Heigth > envelope2.Heigth && envelope1.Width > envelope2.Width) || (envelope1.Heigth > envelope2.Width && envelope1.Width > envelope2.Heigth);
        }
    }
}
