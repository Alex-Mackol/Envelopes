using System;

using TaskEnvelope.Controller;

namespace TaskEnvelope
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvelopeController envelopeController = new EnvelopeController();
            envelopeController.StartAnalizeEnvelopes();
        }
    }
}
