using System;
using System.Collections.Generic;
using System.Text;

namespace FrameDelimiter
{
    public class Frame
    {
        public byte StartOfFrame()
        {
            // TODO: Set start of frame delimiter to AA hexadecimal
            byte startOfFrame = 0;

            Console.WriteLine("A frame always starts with: " + startOfFrame);

            // Please dont change the code below (automatic unit tests)
            return startOfFrame;
        }

        public byte EndOfFrame()
        {
            // TODO: Set end of frame delimiter to 55 hexadecimal
            byte endOfFrame = 0;

            Console.WriteLine("A frame always ends with: " + endOfFrame);

            // Please dont change the code below (automatic unit tests)
            return endOfFrame;
        }
    }
}
