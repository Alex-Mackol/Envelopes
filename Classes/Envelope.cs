using System;


namespace TaskEnvelope.Classes
{
    class Envelope
    {
        private double width;
        private double heigth;

        public double Width
        {
            get => width;
        }
        public double Heigth
        {
            get => heigth;
        }

        public Envelope()
        {
            width = 0;
            heigth = 0;
        }
        public Envelope(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
    }
}
