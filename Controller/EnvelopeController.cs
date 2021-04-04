using System;

using TaskEnvelope.Validator;
using TaskEnvelope.View;
using TaskEnvelope.Classes;

namespace TaskEnvelope.Controller
{
    class EnvelopeController
    {
        DisplayInputEnvelope displayInputEnvelope;
        EnvelopeValidator envelopeValidator;
        EnvelopeComparable envelopeComparable;
        DisplayResultComparable displayResultComparable;
        Display display;

        public EnvelopeController()
        {
            displayInputEnvelope = new DisplayInputEnvelope();
            envelopeValidator = new EnvelopeValidator();
            envelopeComparable = new EnvelopeComparable();
            displayResultComparable = new DisplayResultComparable();
            display = new Display();
        }

        public void StartAnalizeEnvelopes()
        {
            Envelope envelope1;
            Envelope envelope2;

            string widthEnvelope1, heigthEnvelope1;
            string widthEnvelope2, heigthEnvelope2;
            int resultComparable = 0;

            do
            {
                displayInputEnvelope.GetStringForEnvelope(out widthEnvelope1, out heigthEnvelope1, out widthEnvelope2, out heigthEnvelope2);
                if (envelopeValidator.CheckValidationForSides(widthEnvelope1, heigthEnvelope1, widthEnvelope2, heigthEnvelope2))
                {
                    envelope1 = new Envelope(double.Parse(widthEnvelope1), double.Parse(heigthEnvelope1));
                    envelope2 = new Envelope(double.Parse(widthEnvelope2), double.Parse(heigthEnvelope2));

                    resultComparable = envelopeComparable.Compare(envelope1, envelope2);
                    displayResultComparable.DisplayResultAfterComparable(resultComparable);
                }
                else
                {
                    display.DisplayMessage("Exeption!");
                }

            } while (true);
        }
    }
}
