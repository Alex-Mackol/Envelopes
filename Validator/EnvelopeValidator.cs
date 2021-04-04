using System;

namespace TaskEnvelope.Validator
{
    class EnvelopeValidator
    {
        const double MIN_SIZE_OF_ENVELOPE = 0.9;

        public bool CheckValidationForSides(string widthFirst, string heigthFirst, string widthSecond, string heigthSecond)
        {
            if (TryParsing(widthFirst) && TryParsing(heigthFirst) && TryParsing(widthSecond) && TryParsing(heigthSecond) &&
                IsEnvelopeSideMoreThenMinSize(widthFirst, heigthFirst, widthSecond, heigthSecond))
            {
                return true;
            }

            return false;
        }

        private bool TryParsing(string sideInString)
        {
            return double.TryParse(sideInString, out _);
        }

        private bool IsEnvelopeSideMoreThenMinSize(string widthFirst, string heigthFirst, string widthSecond, string heigthSecond)
        {
            return (double.Parse(widthFirst) > MIN_SIZE_OF_ENVELOPE && double.Parse(heigthFirst) > MIN_SIZE_OF_ENVELOPE &&
                double.Parse(widthSecond) > MIN_SIZE_OF_ENVELOPE && double.Parse(heigthSecond) > MIN_SIZE_OF_ENVELOPE);
        }

    }

}
